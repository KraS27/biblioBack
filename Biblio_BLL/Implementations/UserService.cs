using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities;
using Biblio_DOMAIN.Entities.DB;
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

        public async Task<BaseResponse<IEnumerable<User>>> GetAllUsers()
        {
            try
            {
                var users = await _userRepository.GetAll().ToListAsync();

                return new BaseResponse<IEnumerable<User>>
                {
                    Data = users,
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.Ok
                };
            }
            catch(Exception ex)
            {
                return new BaseResponse<IEnumerable<User>>
                {
                    Descriptions = $"[GetAllUsers]: {ex.Message}",
                    Status = Biblio_DOMAIN.Entities.Enum.ResponseStatus.Ok
                };
            }
        }
    }
}
