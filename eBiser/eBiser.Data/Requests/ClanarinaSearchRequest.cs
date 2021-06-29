using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ClanarinaSearchRequest
    {
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
    }
}
