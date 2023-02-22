using FindYourPartyBackend.Data.Models.Dto.DtoFiltersModels;
using FindYourPartyBackend.Data.Models.Dto.DtoModels;
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
        public ActionResult<IEnumerable<ClubDto>> GetClubsAndBasicInfo([FromQuery] GetClubsAndBasicInfoFilterDto getClubsAndBasicInfoFilterDto)
        {
            var ClubsAndBasicInfo = _clubService.GetClubsAndBasicInfo(getClubsAndBasicInfoFilterDto);
            return Ok(ClubsAndBasicInfo);
        }
    }
}
