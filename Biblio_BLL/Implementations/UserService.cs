using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Entities.Response;
using Biblio_DOMAIN.Entities.VIewModels;
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
                .Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    Description = u.Description,
                    UserName = u.UserName,
                    Location = new LocationViewModel()
                    {
                        Country = u.Location.Country,
                        City = u.Location.City,
                    },
                    Followed = u.Followed
                })  
                .Skip(page * usersCount)
                .Take(usersCount)
                .ToListAsync();
               
                return new UserResponse
                {
                    Data = users,
                    UserCount = users.Count,
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.Ok,
                };
            }
            catch(Exception ex)
            {
                return new UserResponse
                {                    
                    Descriptions = $"[GetAllUsers]: {ex.Message}",
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.InternalServerError
                };
            }
        }
    }
}
