﻿using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Response;
using Microsoft.EntityFrameworkCore;

namespace Biblio_BLL.Implementations
{
    public class FollowersService : IFollowersService
    {
        private readonly IBaseRepository<Follower> _followersRepository;

        public FollowersService(IBaseRepository<Follower> followersRepository)
        {
            _followersRepository = followersRepository;
        }

        public async Task<FollowersResponse<int[]>> GetSubscribers(int userId)
        {
            try
            {
                var subscribers = await _followersRepository.GetAll()
                    .Where(f => f.Owner == userId)
                    .Select(f => f.Subscriber)
                    .ToArrayAsync();

                return new FollowersResponse<int[]>
                {
                    Data = subscribers,
                    SubscribersCount = subscribers.Length,
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.Ok
                };
            }
            catch(Exception ex)
            {
                return new FollowersResponse<int[]>
                {
                    Description = $"[GetSubscribers]: " + ex.Message,
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.InternalServerError
                };
            }
        }
    }
}
