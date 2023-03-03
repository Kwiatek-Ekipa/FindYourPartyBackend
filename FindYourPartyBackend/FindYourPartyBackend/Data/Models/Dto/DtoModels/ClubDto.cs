namespace FindYourPartyBackend.Data.Models.Dto.DtoModels
{
    public class ClubDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual List<ClubTypeDto> ClubTypeDtos { get; set; }
        public virtual List<MusicTypeDto> MusicTypeDtos { get; set; }
        public virtual ClubAddressDto Address { get; set; }
    }
}
