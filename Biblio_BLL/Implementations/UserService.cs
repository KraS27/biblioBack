using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities;
using Biblio_DOMAIN.Entities.DB;
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

        public async Task<BaseResponse<IEnumerable<UserViewModel>>> GetAllUsers()
        {
            try
            {
                var users = await _userRepository.GetAll().Select(u => new UserViewModel()
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
                }).ToListAsync();

                return new BaseResponse<IEnumerable<UserViewModel>>
                {
                    Data = users,
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.Ok
                };
            }
            catch(Exception ex)
            {
                return new BaseResponse<IEnumerable<UserViewModel>>
                {
                    Data = null,
                    Descriptions = $"[GetAllUsers]: {ex.Message}",
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.InternalServerError
                };
            }
        }
    }
}
