using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities;
using Biblio_DOMAIN.Entities.DataModels;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Entities.VIewModels;
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
        public async Task<UsersData> GetUsersAsync(int page = 0, int limit = 6)
        {
            var users = await _userService.GetAllUsers(page, limit);
            return users.Data;
        }
    }
}
