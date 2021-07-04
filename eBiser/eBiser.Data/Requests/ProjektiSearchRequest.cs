using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ProjektiSearchRequest
    {
        public bool Prihvaćen { get; set; }
        public DateTime DatumPrijave { get; set; }
        //public double NazivProjekta { get; set; }
        public string OdobrenaSredstva { get; set; }
    }
}
