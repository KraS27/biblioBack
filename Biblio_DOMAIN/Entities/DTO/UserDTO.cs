using Biblio_DOMAIN.Entities.DB;
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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    
        public Location Location { get; set; }

        public string ProfileImg { get; set; }
    }
}
