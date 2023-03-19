using Biblio_DOMAIN.Entities.DTO;

namespace Biblio_DOMAIN.Response
{
    public class UserResponse : BaseResponse<IEnumerable<UserDTO>>
    {
        public int UserCount { get; set; }
    }
}
