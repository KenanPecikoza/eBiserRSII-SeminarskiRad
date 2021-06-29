using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class SastanakSearchRequest
    {
        public int Dan { get; set; }
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public DateTime? Datum { get; set; }
    }
}
