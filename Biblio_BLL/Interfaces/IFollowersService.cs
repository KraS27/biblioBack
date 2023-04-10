using Biblio_DOMAIN.Response;


namespace Biblio_BLL.Interfaces
{
    internal interface IFollowersService
    {
        Task<FollowersResponse> GetSubscribers(int userId);
    }
}
