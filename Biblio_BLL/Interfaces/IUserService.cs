using Biblio_DOMAIN.Response;

namespace Biblio_BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> GetAllUsers(int pages, int usersCount);
    }
}
