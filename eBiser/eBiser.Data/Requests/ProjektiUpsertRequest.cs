using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ProjektiUpsertRequest
    {
        public DateTime DatumPrijave { get; set; }
        public bool Prihvaćen { get; set; }
        public double CijenaProjekta { get; set; }
        public double OdobrenaSredstva { get; set; }
        public string RokIzvrsenja { get; set; }
    }
}
