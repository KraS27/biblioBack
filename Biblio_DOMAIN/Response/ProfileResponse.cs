using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Enum;

namespace Biblio_DOMAIN.Response
{
    public class ProfileResponse 
    {
        public ProfileDTO Profile { get; set; }

        public string Description { get; set; }

        public ResponseStatus Status { get; set; }       
    }
}
