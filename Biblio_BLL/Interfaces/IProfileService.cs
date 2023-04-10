using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_BLL.Interfaces
{
    public interface IProfileService
    {
        Task<BaseResponse<ProfileDTO>> GetProfile(int UserId);
    }
}
