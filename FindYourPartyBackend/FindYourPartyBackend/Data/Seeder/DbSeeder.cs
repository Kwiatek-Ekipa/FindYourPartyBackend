using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels;

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
            if(_dbContext.Database.CanConnect()) 
            { 
                if(!_dbContext.Clubs.Any()) 
                {
                    var clubs = ClubsSeeder.GetClubs();
                    _dbContext.Clubs.AddRange(clubs);
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
