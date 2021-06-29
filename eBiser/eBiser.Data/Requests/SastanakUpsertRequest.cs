using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class SastanakUpsertRequest
    {
        public DateTime DatumOdrzavanja { get; set; }
        public string Zapisnik { get; set; }
        public int OsobljeId { get; set; }
        public bool Odrzan { get; set; }
        public bool Zakazan { get; set; }
        public string Naslov { get; set; }
    }
}
