using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class UlaznaSredstvaSearchRequest
    {
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
