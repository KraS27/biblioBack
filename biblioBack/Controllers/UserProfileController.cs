using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Response;
using Microsoft.AspNetCore.Mvc;

namespace biblioBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<BaseResponse<ProfileDTO>> GetProfile(int userId)
        {
            return await _profileService.GetProfile(userId);
        }
    }
}
