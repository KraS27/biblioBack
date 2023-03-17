using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities.Response;
using Microsoft.AspNetCore.Mvc;

namespace biblioBack.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {     
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUsers")]
        public async Task<UserResponse> GetUsersAsync(int page = 0, int limit = 6)
        {
            var userResponse = await _userService.GetAllUsers(page, limit);
            return userResponse;
        }
    }
}
