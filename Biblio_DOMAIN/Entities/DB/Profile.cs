using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DB
{
    public class Profile
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string ProfileImg { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
