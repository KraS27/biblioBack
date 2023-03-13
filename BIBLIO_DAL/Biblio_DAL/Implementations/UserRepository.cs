using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;


namespace Biblio_DAL.Implementations
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly AppDbContext _appContext;

        public UserRepository(AppDbContext appContext)
        {
            this._appContext = appContext;
        }

        public Task Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            return _appContext.Users;
        }

        public Task<User> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
