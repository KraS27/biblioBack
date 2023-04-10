﻿using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Response
{
    public class FollowersResponse
    {
        public Follower[] Followers { get; set; }
        
        public int FollowersCount { get; set; }

        public string Description { get; set; }

        public ResponseStatus Status { get; set; }
    }
}