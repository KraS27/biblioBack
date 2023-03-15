using Biblio_DOMAIN.Entities;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Entities.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_BLL.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetAllUsers(int pageCount, int usersCount = 6);
    }
}
