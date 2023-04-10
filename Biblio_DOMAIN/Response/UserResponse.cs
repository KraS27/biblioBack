using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Enum;

namespace Biblio_DOMAIN.Response
{
    public class UserResponse<T> : BaseResponse<T>
    {           
        public int UsersCount { get; set; }
    }
}
