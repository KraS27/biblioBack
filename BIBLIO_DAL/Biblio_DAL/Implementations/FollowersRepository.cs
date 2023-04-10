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

        public Task Create(Follower entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Follower entity)
        {
            throw new NotImplementedException();
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
