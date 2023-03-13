using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.VIewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Description { get; set; }

        public LocationViewModel Location { get; set; }

        public bool Followed { get; set; }
    }
}
