using FindYourPartyBackend.Data.Models.DbModels;

namespace FindYourPartyBackend.Data.Seeder
{
    public class ClubTypesSeeder
    {
        public static IEnumerable<ClubType> GetClubTypes()
        {
            var clubTypes = new List<ClubType>()
            {
                new ClubType()
                {
                    Id = 1,
                    TypeName = "Pub"
                },

                new ClubType()
                {
                    Id = 2,
                    TypeName = "Bar"
                },

                new ClubType()
                {
                    Id = 3,
                    TypeName = "Nocny"
                },

                new ClubType()
                {
                    Id = 4,
                    TypeName = "Karaoke"
                },

                new ClubType()
                {
                    Id = 5,
                    TypeName = "LGBT"
                }
            };
            
            return clubTypes;
        }
    }
}
