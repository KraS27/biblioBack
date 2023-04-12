using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DAL.Implementations
{
    public class FollowersRepository : IBaseRepository<Follower>
    {
        private readonly AppDbContext _appDbContext;

        public FollowersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Create(Follower entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(Follower entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public IQueryable<Follower> GetAll()
        {
            return _appDbContext.Followers;
        }

        public Task<Follower> Update(Follower entity)
        {
            throw new NotImplementedException();
        }
    }
}
