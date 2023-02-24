using FindYourPartyBackend.Data.Enums;

namespace FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels
{
    public class GetClubsAndBasicInfoFilterDto
    {
        public string? Name { get; set; }
        public string? AddressCity { get; set; }
        public string? ClubType { get; set; }
        public ClubSizeEnum? ClubSize { get; set; }
        public NumberOfRoomsEnum? NumberOfRooms { get; set; }
        public string? MusicType { get; set; }
    }
}
