using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ProjektiSearchRequest
    {
        public bool? Prihvaćen { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public DateTime? DatumIzvrsenja { get; set; }
        public string NazivProjekta { get; set; }
    }
}
