using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Enum;

namespace Biblio_DOMAIN.Response
{
    public class UserResponse 
    {
        public IEnumerable<UserDTO> Users { get; set; }

        public string Descriptions { get; set; }

        public ResponseStatus Status { get; set; }

        public int UsersCount { get; set; }
    }
}
