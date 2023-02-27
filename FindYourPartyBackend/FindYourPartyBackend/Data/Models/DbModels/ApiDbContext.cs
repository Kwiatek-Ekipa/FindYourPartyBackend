using Microsoft.EntityFrameworkCore;

namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddress { get; set; }
        public DbSet<ClubOpeningHours> ClubOpeningHours { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasOne(a => a.Address)
                .WithOne(b => b.Club)
                .HasForeignKey<ClubAddress>(c => c.ClubId);

            modelBuilder.Entity<Club>()
                .HasOne(a => a.OpeningHours)
                .WithOne(b => b.Club)
                .HasForeignKey<ClubOpeningHours>(c => c.ClubId);

            modelBuilder.Entity<Club>()
                .HasIndex(a => a.Id)
                .IsUnique();

            modelBuilder.Entity<Club>()
                .HasKey(a => a.ClubId);

            modelBuilder.Entity<ClubAddress>()
                .HasKey(a => a.ClubId);

            modelBuilder.Entity<ClubOpeningHours>()
                .HasKey(a => a.ClubId);
        }
    }
}
