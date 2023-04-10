using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Response
{
    public class FollowersResponse<T> : BaseResponse<T>
    {              
        public int SubscribersCount { get; set; }
    }
}
