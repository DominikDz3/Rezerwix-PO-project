using Microsoft.EntityFrameworkCore;
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

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<EventDetail>()
                .Property(ed => ed.PricePerTicket)
                .HasColumnType("decimal(18,2)");

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
                        Username = "admin", Email = "admin@example.com", Role = "admin",
                        PasswordHash = adminHash, Salt = adminSalt, FirstName = "Jan",
                        LastName = "Kowalski", DateOfBirth = DateTime.SpecifyKind(new DateTime(1978, 8, 14), DateTimeKind.Utc)
                    },
                    new User
                    {
                        Username = "anowak", Email = "anowak@example.com", Role = "user",
                        PasswordHash = userHash, Salt = userSalt, FirstName = "Anna",
                        LastName = "Nowak", DateOfBirth = DateTime.SpecifyKind(new DateTime(1999, 5, 20), DateTimeKind.Utc)
                    }
                };
                Users.AddRange(users);
                SaveChanges();
            }
        }
        private void SeedCategories()
        {
            if (!Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Konferencje" },
                    new Category { Name = "Warsztaty" },        
                    new Category { Name = "Koncerty" },         
                    new Category { Name = "Szkolenia Biznesowe" },
                    new Category { Name = "Wystawy Artystyczne" },
                    new Category { Name = "Spotkania Networkingowe" },
                    new Category { Name = "Sport" }
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
                        Title = "Konferencja IT Masters",
                        Description = "Doroczna konferencja programistyczna dla profesjonalistów IT.",
                        StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(30), DateTimeKind.Utc),
                        EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(31), DateTimeKind.Utc),
                        Location = "Warszawa, PGE Narodowy"
                    },
                    new Event
                    {
                        Title = "Warsztaty Agile & Scrum",
                        Description = "Intensywne warsztaty z metodyk zwinnych C# i .NET.",
                        StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(45), DateTimeKind.Utc),
                        EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(46), DateTimeKind.Utc),
                        Location = "Kraków, Hub Kolektyw"
                    },
                    new Event
                    {
                        Title = "Jazzowy Wieczór nad Wisłą",
                        Description = "Plenerowy koncert najlepszych polskich zespołów jazzowych.",
                        StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(60), DateTimeKind.Utc),
                        EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(60).AddHours(3), DateTimeKind.Utc),
                        Location = "Warszawa, Bulwary Wiślane"
                    },
                    new Event
                    {
                        Title = "Sztuka Abstrakcji XX Wieku",
                        Description = "Wystawa prac pionierów abstrakcjonizmu.",
                        StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(20), DateTimeKind.Utc),
                        EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(50), DateTimeKind.Utc),
                        Location = "Poznań, Muzeum Narodowe"
                    },
                    new Event
                    {
                        Title = "Startup Connect Rzeszów",
                        Description = "Spotkanie dla innowatorów, founderów i inwestorów z regionu Podkarpacia.",
                        StartDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(25), DateTimeKind.Utc),
                        EndDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(25).AddHours(5), DateTimeKind.Utc),
                        Location = "Rzeszów, Urban Lab"
                    }
                };
                Events.AddRange(events);
                SaveChanges();
            }
        }

        private void SeedEventDetails()
        {
            if (!EventDetails.Any())
            {
                var allEvents = Events.ToList();
                if (allEvents.Count < 5)
                {
                    Console.WriteLine("OSTRZEŻENIE: Nie wszystkie wydarzenia zostały poprawnie załadowane do SeedEventDetails.");
                    return;
                }

                var details = new List<EventDetail>
                {
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Konferencja IT Masters").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Konferencja IT Masters").StartDate,
                                      AvailableSeats = 100, PricePerTicket = 299.99m },
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Konferencja IT Masters").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Konferencja IT Masters").StartDate.AddDays(1),
                                      AvailableSeats = 80, PricePerTicket = 299.99m },
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Warsztaty Agile & Scrum").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Warsztaty Agile & Scrum").StartDate,
                                      AvailableSeats = 30, PricePerTicket = 450.00m },
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Jazzowy Wieczór nad Wisłą").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Jazzowy Wieczór nad Wisłą").StartDate,
                                      AvailableSeats = 200, PricePerTicket = 75.50m },
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Sztuka Abstrakcji XX Wieku").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Sztuka Abstrakcji XX Wieku").StartDate,
                                      AvailableSeats = 500, PricePerTicket = 40.00m },
                    new EventDetail { EventId = allEvents.First(e => e.Title == "Startup Connect Rzeszów").EventId,
                                      EventDate = allEvents.First(e => e.Title == "Startup Connect Rzeszów").StartDate,
                                      AvailableSeats = 150, PricePerTicket = 0.00m }
                };
                EventDetails.AddRange(details);
                SaveChanges();
            }
        }

        private void SeedEventCategories()
        {
            if (!EventCategories.Any())
            {
                var allEvents = Events.ToList();
                var allCategories = Categories.ToList();
                if (allEvents.Count < 5 || allCategories.Count < 7)
                {
                    Console.WriteLine("OSTRZEŻENIE: Nie wszystkie wydarzenia/kategorie zostały poprawnie załadowane do SeedEventCategories.");
                    return;
                }

                var eventCategories = new List<EventCategory>
                {
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Konferencja IT Masters").EventId, CategoryId = allCategories.First(c => c.Name == "Konferencje").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Konferencja IT Masters").EventId, CategoryId = allCategories.First(c => c.Name == "Szkolenia Biznesowe").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Warsztaty Agile & Scrum").EventId, CategoryId = allCategories.First(c => c.Name == "Warsztaty").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Warsztaty Agile & Scrum").EventId, CategoryId = allCategories.First(c => c.Name == "Szkolenia Biznesowe").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Jazzowy Wieczór nad Wisłą").EventId, CategoryId = allCategories.First(c => c.Name == "Koncerty").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Sztuka Abstrakcji XX Wieku").EventId, CategoryId = allCategories.First(c => c.Name == "Wystawy Artystyczne").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Startup Connect Rzeszów").EventId, CategoryId = allCategories.First(c => c.Name == "Spotkania Networkingowe").CategoryId },
                    new EventCategory { EventId = allEvents.First(e => e.Title == "Startup Connect Rzeszów").EventId, CategoryId = allCategories.First(c => c.Name == "Konferencje").CategoryId },
                };
                EventCategories.AddRange(eventCategories);
                SaveChanges();
            }
        }

        private void SeedReservations()
        {
            if (!Reservations.Any() && Users.Any(u => u.Username == "anowak") && EventDetails.Any())
            {
                var userAnowak = Users.First(u => u.Username == "anowak");
                var allEventDetails = EventDetails.Include(ed => ed.Event).ToList();

                if (allEventDetails.Count < 3)
                {
                    Console.WriteLine("OSTRZEŻENIE: Niewystarczająca liczba EventDetails do stworzenia rezerwacji startowych.");
                    return;
                }

                var jazzEventDetail = allEventDetails.FirstOrDefault(ed => ed.Event.Title == "Jazzowy Wieczór nad Wisłą");
                var itConfDay1Detail = allEventDetails.FirstOrDefault(ed => ed.Event.Title == "Konferencja IT Masters" && ed.EventDate == ed.Event.StartDate);

                var reservations = new List<Reservation>();

                if (itConfDay1Detail != null)
                {
                    reservations.Add(new Reservation
                    {
                        UserId = userAnowak.UserId,
                        EventDetailId = itConfDay1Detail.EventDetailId,
                        ReservationDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(-5), DateTimeKind.Utc),
                        NumberOfTickets = 2
                    });
                }
                if (jazzEventDetail != null)
                {
                    reservations.Add(new Reservation
                    {
                        UserId = userAnowak.UserId,
                        EventDetailId = jazzEventDetail.EventDetailId,
                        ReservationDate = DateTime.SpecifyKind(DateTime.UtcNow.AddDays(-2), DateTimeKind.Utc),
                        NumberOfTickets = 1
                    });
                }

                if (reservations.Any())
                {
                    Reservations.AddRange(reservations);
                    SaveChanges();
                }
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
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
                return (Convert.ToBase64String(pbkdf2.GetBytes(HashSize)), Convert.ToBase64String(salt));
            }

            public static bool VerifyPassword(string password, string storedHash, string storedSalt)
            {
                byte[] salt = Convert.FromBase64String(storedSalt);
                byte[] hash = Convert.FromBase64String(storedHash);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
                return pbkdf2.GetBytes(HashSize).SequenceEqual(hash);
            }
        }
    }
}

