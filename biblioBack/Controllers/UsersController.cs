using Biblio_BLL.Interfaces;
using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Response;
using Microsoft.AspNetCore.Mvc;

namespace biblioBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {     
        private readonly IUserService _userService;
        private readonly IFollowersService _followersService;

        public UsersController(IUserService userService, IFollowersService followersService)
        {
            _userService = userService;
            _followersService = followersService;
        }

        [HttpGet]
        public async Task<UserResponse<IEnumerable<UserDTO>>> GetUsersAsync(int page = 1, int limit = 6)
        {
            var userResponse = await _userService.GetAllUsers(page, limit);
            return userResponse;
        }

        [HttpGet("/users/subscribers")]
        public async Task<FollowersResponse<int[]>> GetSubscribersAsync(int userId)
        {
            return await _followersService.GetSubscribers(userId);
        }

        [HttpPost("/users/subscribers")]
        public async Task<FollowersResponse<bool>> AddSubscriberAsync(int ownerId, int subscriberId)
        {
            return await _followersService.AddSubscriber(ownerId, subscriberId);
        }

        [HttpDelete("/users/subscribers")]
        public async Task<FollowersResponse<bool>> RemoveSubscriberAsync(int ownerId, int subscriberId)
        {
            return await _followersService.RemoveSubscriber(ownerId, subscriberId);
        }
    }
}
