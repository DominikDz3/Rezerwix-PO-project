using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rezerwix.Models;
using System.Security.Cryptography;

namespace Rezerwix.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracja relacji
            modelBuilder.Entity<EventCategory>()
                .HasKey(ec => new { ec.EventId, ec.CategoryId });

            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventCategories)
                .HasForeignKey(ec => ec.EventId);

            modelBuilder.Entity<EventCategory>()
                .HasOne(ec => ec.Category)
                .WithMany(c => c.EventCategories)
                .HasForeignKey(ec => ec.CategoryId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventDetails)
                .WithOne(ed => ed.Event)
                .HasForeignKey(ed => ed.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.EventDetail)
                .WithMany(ed => ed.Reservations)
                .HasForeignKey(r => r.EventDetailId)
                .OnDelete(DeleteBehavior.Restrict);

            // Konfiguracje dodatkowe
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<EventDetail>()
                .Property(ed => ed.AvailableSeats)
                .IsRequired();
        }

        public void SeedData()
        {
            using var transaction = Database.BeginTransaction();
            try
            {
                SeedUsers();
                SeedCategories();
                SeedEvents();
                SeedEventDetails();
                SeedEventCategories();
                SeedReservations();

                SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private void SeedUsers()
        {
            if (!Users.Any())
            {
                var (adminHash, adminSalt) = PasswordHasher.HashPassword("Admin123!");
                var (userHash, userSalt) = PasswordHasher.HashPassword("User123!");

                var users = new List<User>
        {
            new User
            {
                Username = "admin",
                Email = "admin@example.com",
                PasswordHash = adminHash,
                Salt = adminSalt,
                FirstName = "Jan",
                LastName = "Kowalski",
                DateOfBirth = DateTime.SpecifyKind(new DateTime(1978, 8, 14), DateTimeKind.Utc)
            },
            new User
            {
                Username = "anowak",
                Email = "anowak@example.com",
                PasswordHash = userHash,
                Salt = userSalt,
                FirstName = "Anna",
                LastName = "Nowak",
                DateOfBirth = DateTime.SpecifyKind(new DateTime(1999, 5, 20), DateTimeKind.Utc)
            }
        };

                Users.AddRange(users);
                SaveChanges(); // Zapisujemy aby mieć ID
            }
        }
        private void SeedCategories() {
            if (!Categories.Any())
            {
                var categories = new List<Category>
        {
            new Category { Name = "Konferencje" },
            new Category { Name = "Warsztaty" },
            new Category { Name = "Koncerty" }
        };

                Categories.AddRange(categories);
                SaveChanges();
            }
        }

        private void SeedEvents()
        {
            if (!Events.Any())
            {
                var events = new List<Event>
        {
            new Event
            {
                Title = "Konferencja IT",
                Description = "Doroczna konferencja programistyczna",
                StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(30), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(30), DateTimeKind.Utc),
                Location = "Warszawa"
            },
            new Event
            {
                Title = "Warsztaty programowania",
                Description = "Warsztaty z C# i .NET",
                StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(15), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(12), DateTimeKind.Utc),
                Location = "Kraków"
            }
        };

                Events.AddRange(events);
                SaveChanges(); // Zapisujemy aby mieć ID eventów
            }
        }

        private void SeedEventDetails()
        {
            if (!EventDetails.Any())
            {
                var events = Events.ToList();

                var details = new List<EventDetail>
        {
            new EventDetail
            {
                EventId = events[0].EventId,
                EventDate = events[0].StartDate,
                AvailableSeats = 100
            },
            new EventDetail
            {
                EventId = events[1].EventId,
                EventDate = events[1].StartDate,
                AvailableSeats = 30
            }
        };
                EventDetails.AddRange(details);
                SaveChanges();
            }
        }

        private void SeedEventCategories()
        {
            if (!EventCategories.Any())
            {
                var events = Events.ToList();
                var categories = Categories.ToList();

                var eventCategories = new List<EventCategory>
        {
            new EventCategory { EventId = events[0].EventId, CategoryId = categories[0].CategoryId },
            new EventCategory { EventId = events[0].EventId, CategoryId = categories[1].CategoryId },
            new EventCategory { EventId = events[1].EventId, CategoryId = categories[1].CategoryId }
        };

                EventCategories.AddRange(eventCategories);
                SaveChanges();
            }
        }

        private void SeedReservations()
        {
            if (!Reservations.Any())
            {
                var user = Users.First(u => u.Username == "anowak");
                var eventDetail = EventDetails.First();

                var reservation = new Reservation
                {
                    UserId = user.UserId,
                    EventDetailId = eventDetail.EventDetailId,
                    ReservationDate = DateTime.SpecifyKind(new DateTime(2025, 5, 10), DateTimeKind.Utc),
                    NumberOfTickets = 1
                };

                Reservations.Add(reservation);
                SaveChanges();
            }
        }

        public static class PasswordHasher
        {
            private const int Iterations = 100_000;
            private const int SaltSize = 16;
            private const int HashSize = 20;

            public static (string Hash, string Salt) HashPassword(string password)
            {
                byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
                var pbkdf2 = new Rfc2898DeriveBytes(
                    password, salt, Iterations, HashAlgorithmName.SHA256);
                return (
                    Convert.ToBase64String(pbkdf2.GetBytes(HashSize)),
                    Convert.ToBase64String(salt)
                );
            }

            public static bool VerifyPassword(string password, string storedHash, string storedSalt)
            {
                byte[] salt = Convert.FromBase64String(storedSalt);
                byte[] hash = Convert.FromBase64String(storedHash);
                var pbkdf2 = new Rfc2898DeriveBytes(
                    password, salt, Iterations, HashAlgorithmName.SHA256);
                return pbkdf2.GetBytes(HashSize).SequenceEqual(hash);
            }
        }
    }
}