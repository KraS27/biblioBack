using Biblio_DOMAIN.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_BLL.Interfaces
{
    internal interface IProfileService
    {
        Task<ProfileResponse> GetProfile(int UserId);
    }
}
