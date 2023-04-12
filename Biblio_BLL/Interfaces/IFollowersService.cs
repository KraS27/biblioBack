using Biblio_DOMAIN.Response;


namespace Biblio_BLL.Interfaces
{
    public interface IFollowersService
    {
        Task<FollowersResponse<int[]>> GetSubscribers(int userId);

        Task<FollowersResponse<bool>> AddSubscriber(int ownnerId, int subscriberId);

        Task<FollowersResponse<bool>> RemoveSubscriber(int ownerId, int subscriberId);
    }
}
