using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Osoblje
    {
        public Osoblje()
        {
            AkcijePomocis = new HashSet<AkcijePomoci>();
            IzlaznaSredstvas = new HashSet<IzlaznaSredstva>();
            Obavijestis = new HashSet<Obavijesti>();
            Projektis = new HashSet<Projekti>();
            Sastanaks = new HashSet<Sastanak>();
            UlaznaSredstvas = new HashSet<UlaznaSredstva>();
        }

        public int Id { get; set; }
        public DateTime DatumPocetkaAngazmana { get; set; }
        public int DjelatnostId { get; set; }
        public int KorisnikId { get; set; }

        public virtual DjelatnostOsoblje Djelatnost { get; set; }
        public virtual KorisniciSistema Korisnik { get; set; }
        public virtual ICollection<AkcijePomoci> AkcijePomocis { get; set; }
        public virtual ICollection<IzlaznaSredstva> IzlaznaSredstvas { get; set; }
        public virtual ICollection<Obavijesti> Obavijestis { get; set; }
        public virtual ICollection<Projekti> Projektis { get; set; }
        public virtual ICollection<Sastanak> Sastanaks { get; set; }
        public virtual ICollection<UlaznaSredstva> UlaznaSredstvas { get; set; }
    }
}
