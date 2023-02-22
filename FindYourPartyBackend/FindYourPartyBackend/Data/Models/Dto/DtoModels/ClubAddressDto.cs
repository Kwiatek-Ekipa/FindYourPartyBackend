using FindYourPartyBackend.Data.Models.DbModels;

namespace FindYourPartyBackend.Data.Models.Dto.DtoModels
{
    public class ClubAddressDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

    }
}
