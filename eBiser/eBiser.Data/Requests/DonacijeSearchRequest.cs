using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class DonacijeSearchRequest
    {
        public int KorisnikSistemaId { get; set; }
        public string Naziv { get; set; }
        public string OpisDonacije { get; set; }
        public  DateTime? DatumPrijave { get; set; }
        public bool? NaCekanju { get; set; }
    }
}
