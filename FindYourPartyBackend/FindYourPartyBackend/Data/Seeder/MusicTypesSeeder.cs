using FindYourPartyBackend.Data.Models.DbModels;

namespace FindYourPartyBackend.Data.Seeder
{
    public class MusicTypesSeeder
    {
        public static IEnumerable<MusicType> GetMusicTypes()
        {
            var musicTypes = new List<MusicType>()
            {
                new MusicType()
                {
                    Id = 1,
                    TypeName = "Pop"
                },

                new MusicType()
                {
                    Id = 2,
                    TypeName = "Rap"
                },

                new MusicType()
                {
                    Id = 3,
                    TypeName = "Electro"
                },

                new MusicType()
                {
                    Id = 4,
                    TypeName = "Rock"
                },

                new MusicType()
                {
                    Id = 5,
                    TypeName = "Blues&Jazz"
                },

                new MusicType()
                {
                    Id = 6,
                    TypeName = "Klasyczna"
                }
            };

            return musicTypes;
        }
    }
}
