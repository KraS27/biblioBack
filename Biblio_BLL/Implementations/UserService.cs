using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Enum;
using Biblio_DOMAIN.Response;
using Microsoft.EntityFrameworkCore;

namespace Biblio_BLL.Implementations
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userRepository;

        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponse> GetAllUsers(int page, int usersCount)
        {
            try
            {
                var users = await _userRepository.GetAll()
                        .Select(u => new UserDTO()
                        {
                            Id = u.Id,
                            UserName = u.UserName,
                            ProfileImg = u.UserProfile.ProfileImg,
                            Status = u.UserProfile.Status
                        })
                        .Skip((page - 1) * usersCount) // because pageNumbers started from 1, and if we don't substract 1, we will be skip first some users
                        .Take(usersCount)
                        .ToListAsync();

                if(users.Count > 0)
                {
                    return new UserResponse
                    {
                        Users = users,
                        UsersCount = await _userRepository.GetAll().CountAsync(),
                        Status = ResponseStatus.Ok
                    };
                }
                else
                {
                    return new UserResponse
                    {
                        Status = ResponseStatus.NotFound,
                        Description = "Users Not Found"
                    };
                }
            }
            catch(Exception ex)
            {
                return new UserResponse
                {
                    Description = $"[GetAllUsers]: {ex.Message}",
                    Status = ResponseStatus.InternalServerError
                };
            }
        }
    }
}
