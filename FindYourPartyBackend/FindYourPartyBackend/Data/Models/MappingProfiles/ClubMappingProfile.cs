using AutoMapper;
using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;

namespace FindYourPartyBackend.Data.Models.MappingProfiles
{
    public class ClubMappingProfile : Profile
    {
        public ClubMappingProfile() 
        {
            CreateMap<Club, ClubDto>();
            CreateMap<ClubAddress, ClubAddressDto>();
        }
    }
}
