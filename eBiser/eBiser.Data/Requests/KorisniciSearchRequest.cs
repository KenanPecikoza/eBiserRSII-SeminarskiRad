using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class KorisniciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public bool? Aktivan { get; set; }
        public class OsobljeSearchRequest : KorisniciSearchRequest
        {
            public int DjelatnostId { get; set; }
            public DateTime DatumPocetkaAngazmana { get; set; }
        }

    }
}
