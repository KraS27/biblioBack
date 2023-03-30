using Biblio_BLL.Interfaces;
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
        public Task<ProfileResponse> GetProfile(int userId)
        {
            return _profileService.GetProfile(userId);
        }
    }
}
