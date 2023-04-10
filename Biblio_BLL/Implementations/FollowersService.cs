using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Response;
using Microsoft.EntityFrameworkCore;

namespace Biblio_BLL.Implementations
{
    internal class FollowersService : IFollowersService
    {
        private readonly IBaseRepository<Follower> _followersRepository;

        public FollowersService(IBaseRepository<Follower> followersRepository)
        {
            _followersRepository = followersRepository;
        }

        public async Task<FollowersResponse> GetSubscribers(int userId)
        {
            try
            {
                var followers = await _followersRepository.GetAll().Where(f => f.Owner == userId).ToArrayAsync();

                return new FollowersResponse
                {
                    Followers = followers,
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.Ok
                };
            }
            catch(Exception ex)
            {
                return new FollowersResponse
                {
                    Description = $"[GetSubscribers]: " + ex.Message,
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.InternalServerError
                };
            }
        }
    }
}
