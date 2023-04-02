using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DTO
{
    public class ProfileDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? ProfileImg { get; set; }

        public string? Status { get; set; }

        public LocationDTO Location { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
