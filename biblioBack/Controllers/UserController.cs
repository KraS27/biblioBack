using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities;
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
        public async Task<IEnumerable<UserViewModel>> GetUsersAsync(int pageCount = 0)
        {
            var users = await _userService.GetAllUsers(pageCount);
            return users.Data;
        }
    }
}
