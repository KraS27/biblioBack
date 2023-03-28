using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;

namespace Biblio_DAL.Implementations
{
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly AppDbContext _appContext;

        public ProfileRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
     
        public Task Create(Profile entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Profile entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Profile> GetAll()
        {
            return _appContext.Profiles;
        }

        public Task<Profile> Update(Profile entity)
        {
            throw new NotImplementedException();
        }
    }
}
