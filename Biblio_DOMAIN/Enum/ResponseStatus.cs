using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DOMAIN.Enum
{
    public enum ResponseStatus
    {
        Ok = 200,
        NotFound = 400,
        InternalServerError = 500
    }
}
