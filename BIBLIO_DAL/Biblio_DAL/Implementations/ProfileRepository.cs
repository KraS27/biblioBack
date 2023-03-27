using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;

namespace Biblio_DAL.Implementations
{
    public class ProfileRepository : IBaseRepository<UserProfile>
    {
        private readonly AppDbContext _appContext;

        public ProfileRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
     
        public Task Create(UserProfile entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserProfile entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserProfile> GetAll()
        {
            return _appContext.Profiles;
        }

        public Task<UserProfile> Update(UserProfile entity)
        {
            throw new NotImplementedException();
        }
    }
}
