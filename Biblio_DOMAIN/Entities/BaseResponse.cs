﻿using Biblio_DOMAIN.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Entities
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }

        public string Descriptions { get; set; }

        public ResponseStatus Status { get; set; }
    }
}
