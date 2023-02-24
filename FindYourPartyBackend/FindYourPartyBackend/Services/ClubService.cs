using AutoMapper;
using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace FindYourPartyBackend.Services
{
    public interface IClubService
    {
        IEnumerable<ClubDto> GetClubsAndBasicInfo(GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto);
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

        public IEnumerable<ClubDto> GetClubsAndBasicInfo(GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto)
        {
            var ClubsAndBasicInfo = _dbContext.Clubs
                .Include(club => club.Address)
                .Where(club => club.Name.ToLower().Contains(getClubsAndBasicInfoFilterDto.Name.ToLower() ?? club.Name.ToLower()))
                .Where(club => club.Address.City.Equals(getClubsAndBasicInfoFilterDto.AddressCity ?? club.Address.City))
                .Where(club => club.ClubSize.Equals(getClubsAndBasicInfoFilterDto.ClubSize ?? club.ClubSize))
                .Where(club => club.ClubType.ToLower().Contains(getClubsAndBasicInfoFilterDto.ClubType.ToLower() ?? club.ClubType.ToLower()))
                .Where(club => club.NumberOfRooms.Equals(getClubsAndBasicInfoFilterDto.NumberOfRooms ?? club.NumberOfRooms))
                .Where(club => club.MusicType.ToLower().Contains(getClubsAndBasicInfoFilterDto.MusicType.ToLower() ?? club.MusicType.ToLower()))
                .ToList();

            var result = _mapper.Map<List<ClubDto>>(ClubsAndBasicInfo);

            return result;
        }
    }
}
