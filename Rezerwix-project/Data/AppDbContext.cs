using Microsoft.EntityFrameworkCore;
using Rezerwix.Models;


namespace Rezerwix.Data
{
    public class AppDbContext : DbContext
    {
        // Konstruktor (ważne dla konfiguracji)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        // Tabele
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --------------------------------------------
            // Relacje wymagane na 5.0
            // --------------------------------------------

            // Relacja N:M (Event ↔ Category)
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

            // Relacja 1:N (User → Reservation)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // --------------------------------------------
            // Pozostałe relacje
            // --------------------------------------------

            // Relacja 1:N (Event → EventDetail)
            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventDetails)
                .WithOne(ed => ed.Event)
                .HasForeignKey(ed => ed.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacja Reservation → EventDetail
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.EventDetail)
                .WithMany(ed => ed.Reservations)
                .HasForeignKey(r => r.EventDetailId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------------------------------------------
            // Walidacja i indeksy
            // --------------------------------------------

            // Unikalny username
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Wymagane pola
            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<EventDetail>()
                .Property(ed => ed.AvailableSeats)
                .IsRequired();
        }
    }
}