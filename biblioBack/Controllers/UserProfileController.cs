using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Response;
using Microsoft.AspNetCore.Mvc;

namespace biblioBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public UserProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        [HttpGet("GetProfile")]
        public Task<ProfileResponse> GetProfile(int userId)
        {
            return _profileService.GetProfile(userId);
        }
    }
}
