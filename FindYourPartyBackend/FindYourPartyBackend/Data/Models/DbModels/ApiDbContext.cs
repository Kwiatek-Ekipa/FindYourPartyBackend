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
        public DbSet<ClubType> ClubTypes { get; set; }
        public DbSet<MusicType> MusicTypes { get; set; }
        public DbSet<ClubClubType> ClubClubTypes { get; set; }
        public DbSet<ClubMusicType> ClubMusicTypes { get; set; }

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

            modelBuilder.Entity<ClubClubType>().HasKey(a => new { a.ClubTypeId, a.ClubId });
            modelBuilder.Entity<ClubClubType>()
                .HasOne<ClubType>(sc => sc.ClubType)
                .WithMany(s => s.ClubClubTypes)
                .HasForeignKey(sc => sc.ClubTypeId);
            modelBuilder.Entity<ClubClubType>()
                .HasOne<Club>(sc => sc.Club)
                .WithMany(s => s.ClubClubTypes)
                .HasForeignKey(sc => sc.ClubId);

            modelBuilder.Entity<ClubMusicType>().HasKey(a => new { a.MusicTypeId, a.ClubId });
            modelBuilder.Entity<ClubMusicType>()
                .HasOne<MusicType>(sc => sc.MusicType)
                .WithMany(s => s.ClubMusicTypes)
                .HasForeignKey(sc => sc.MusicTypeId);
            modelBuilder.Entity<ClubMusicType>()
                .HasOne<Club>(sc => sc.Club)
                .WithMany(s => s.ClubMusicTypes)
                .HasForeignKey(sc => sc.ClubId);
        }
    }
}
