using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
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
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _userService.GetAllUsers();
            return users.Data;
        }
    }
}
