using FindYourPartyBackend.Data.Models.DbModels;

namespace FindYourPartyBackend.Data.Seeder
{
    public class DbSeeder
    {
        public readonly ApiDbContext _dbContext;
        public DbSeeder(ApiDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Clubs.Any() && !_dbContext.ClubTypes.Any() && !_dbContext.MusicTypes.Any())
                {
                    var clubs = ClubsSeeder.GetClubs();
                    var clubTypes = ClubTypesSeeder.GetClubTypes();
                    var musicTypes = MusicTypesSeeder.GetMusicTypes();
                    _dbContext.Clubs.AddRange(clubs);
                    _dbContext.ClubTypes.AddRange(clubTypes);
                    _dbContext.MusicTypes.AddRange(musicTypes);
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
