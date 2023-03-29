using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string SmallDescription { get; set; }

        public LocationDTO Location { get; set; }

        public string ProfileImg { get; set; }

        public bool Followed { get; set; }
    }
}
