using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Response;

namespace Biblio_BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse<IEnumerable<UserDTO>>> GetAllUsers(int pages, int usersCount);
    }
}
