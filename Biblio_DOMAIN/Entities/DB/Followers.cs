using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DB
{
    public class Follower
    {
        public int Id { get; set; }

        public int Owner { get; set; }

        public int Subscriber { get; set; }
    }
}
