using FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;
using FindYourPartyBackend.Data.Models.Dto.DtoPagination;
using FindYourPartyBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FindYourPartyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService) 
        { 
            _clubService = clubService;
        }

        [HttpGet]
        public ActionResult<PagedResultDto<ClubDto>> GetClubsAndBasicInfo([FromQuery] GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto, [FromQuery] PaginationDto paginationDto)
        {
            var ClubsAndBasicInfo = _clubService.GetClubsAndBasicInfo(getClubsAndBasicInfoFilterDto, paginationDto);
            return Ok(ClubsAndBasicInfo);
        }
    }
}
