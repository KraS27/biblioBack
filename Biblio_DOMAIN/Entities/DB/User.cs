using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DB
{
    public class User
    {
        public int Id { get; set; }
       
        public string UserName { get; set; }

        public string Email { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
            
        public Profile UserProfile { get; set; }
    }
}
