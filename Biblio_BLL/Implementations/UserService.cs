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
                return new UserResponse
                {
                    Users = await _userRepository.GetAll()
                        .Select(u => new UserDTO()
                        {
                            Id = u.Id,
                            Description = u.Description,
                            UserName = u.UserName,
                            Location = new LocationDTO()
                            {
                                Country = u.Location.Country,
                                City = u.Location.City,
                            },
                            Followed = u.Followed
                        })
                        .Skip((page - 1) * usersCount) // because pageNumbers started from 1, and if we don't substract 1, we will be skip first some users
                        .Take(usersCount)
                        .ToListAsync(),
                    UsersCount = await _userRepository.GetAll().CountAsync(),
                    Status = ResponseStatus.Ok
                };
            }
            catch(Exception ex)
            {
                return new UserResponse
                {                    
                    Descriptions = $"[GetAllUsers]: {ex.Message}",
                    Status = ResponseStatus.InternalServerError
                };
            }
        }
    }
}
