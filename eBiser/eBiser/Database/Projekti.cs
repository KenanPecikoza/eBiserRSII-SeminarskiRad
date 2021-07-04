using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Projekti
    {
        public int Id { get; set; }
        public string NazivProjekta { get; set; }
        public DateTime DatumPrijave { get; set; }
        public bool Prihvaćen { get; set; }
        public double CijenaProjekta { get; set; }
        public double OdobrenaSredstva { get; set; }
        public string RokIzvrsenja { get; set; }
        public int OsobljeId { get; set; }
        public DateTime DatumIzvrsenja { get; set; }
        public virtual Osoblje Osoblje { get; set; }
    }
}
