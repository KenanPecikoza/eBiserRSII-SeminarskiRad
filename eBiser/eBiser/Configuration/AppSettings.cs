using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Configuration
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string AccessTokenIssuer { get; set; }
    }
}
