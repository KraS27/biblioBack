using Biblio_DOMAIN.Entities.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.Response
{
    public class UserResponse : BaseResponse<IEnumerable<UserViewModel>>
    {
        public int UserCount { get; set; }
    }
}
