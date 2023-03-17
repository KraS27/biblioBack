using Biblio_DOMAIN.Entities.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities.DataModels
{
    public class UsersData
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        public int UsersCount { get; set; }
    }
}
