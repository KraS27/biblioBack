using Biblio_DOMAIN.Response;


namespace Biblio_BLL.Interfaces
{
    public interface IFollowersService
    {
        Task<FollowersResponse> GetSubscribers(int userId);
       
    }
}
