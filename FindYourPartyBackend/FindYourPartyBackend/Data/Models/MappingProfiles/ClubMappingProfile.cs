using AutoMapper;
using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;

namespace FindYourPartyBackend.Data.Models.MappingProfiles
{
    public class ClubMappingProfile : Profile
    {
        public ClubMappingProfile() 
        {
            CreateMap<Club, ClubDto>()
                .ForMember(dto => dto.ClubTypeDtos, opt => opt.MapFrom(x => x.ClubClubTypes.Select(y => y.ClubType).ToList()))
                .ForMember(dto => dto.MusicTypeDtos, opt => opt.MapFrom(x => x.ClubMusicTypes.Select(y => y.MusicType).ToList()));
            
            CreateMap<ClubType, ClubTypeDto>();
            CreateMap<MusicType, MusicTypeDto>();

            CreateMap<ClubClubType, ClubTypeDto>();
            CreateMap<ClubMusicType, MusicTypeDto>();

            CreateMap<ClubAddress, ClubAddressDto>();
        }
    }
}
