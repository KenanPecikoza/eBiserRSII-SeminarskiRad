using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ProjektiUpsertRequest
    {
        public string NazivProjekta { get; set; }

        public DateTime DatumPrijave { get; set; }
        public DateTime DatumIzvrsenja { get; set; }
        public bool Prihvaćen { get; set; }
        public double CijenaProjekta { get; set; }
        public double OdobrenaSredstva { get; set; }
        public string RokIzvrsenja { get; set; }
        public int OsobljeId { get; set; }
    }
}
