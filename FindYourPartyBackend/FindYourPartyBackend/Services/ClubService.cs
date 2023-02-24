using AutoMapper;
using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;
using FindYourPartyBackend.Data.Models.Dto.DtoPagination;
using Microsoft.EntityFrameworkCore;

namespace FindYourPartyBackend.Services
{
    public interface IClubService
    {
        PagedResultDto<ClubDto> GetClubsAndBasicInfo(GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto, PaginationDto paginationDto);
    }

    public class ClubService : IClubService
    {
        private readonly ApiDbContext _dbContext;
        public readonly IMapper _mapper;

        public ClubService(ApiDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public PagedResultDto<ClubDto> GetClubsAndBasicInfo(GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto, PaginationDto paginationDto)
        {
            var allClubsAndBasicInfo = _dbContext.Clubs
                .Include(club => club.Address)
                .Where(club => getClubsAndBasicInfoFilterDto.Name == null || club.Name.ToLower().Contains(getClubsAndBasicInfoFilterDto.Name.ToLower()))
                .Where(club => getClubsAndBasicInfoFilterDto.AddressCity == null || club.Address.City.Equals(getClubsAndBasicInfoFilterDto.AddressCity))
                .Where(club => getClubsAndBasicInfoFilterDto.ClubSize == null || club.ClubSize.Equals(getClubsAndBasicInfoFilterDto.ClubSize))
                .Where(club => getClubsAndBasicInfoFilterDto.ClubType == null || club.ClubType.ToLower().Contains(getClubsAndBasicInfoFilterDto.ClubType.ToLower()))
                .Where(club => getClubsAndBasicInfoFilterDto.NumberOfRooms == null || club.NumberOfRooms.Equals(getClubsAndBasicInfoFilterDto.NumberOfRooms))
                .Where(club => getClubsAndBasicInfoFilterDto.MusicType == null || club.MusicType.ToLower().Contains(getClubsAndBasicInfoFilterDto.MusicType.ToLower()));

            List<Club> paginationClubsAndBasicInfo;
            if (paginationDto.PageSize == -1)
            {
                paginationClubsAndBasicInfo = allClubsAndBasicInfo.ToList();
            }
            else
            {
                paginationClubsAndBasicInfo = allClubsAndBasicInfo
                                                .Skip(paginationDto.PageSize * (paginationDto.PageIndex - 1))
                                                .Take(paginationDto.PageSize)
                                                .ToList();
            }

            var clubsDto = _mapper.Map<List<ClubDto>>(paginationClubsAndBasicInfo);

            var result = new PagedResultDto<ClubDto>(clubsDto, allClubsAndBasicInfo.Count(), paginationDto.PageSize, paginationDto.PageIndex);

            return result;
        }
    }
}
