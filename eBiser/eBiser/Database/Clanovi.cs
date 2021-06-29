using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Clanovi
    {
        public Clanovi()
        {
            Clanarinas = new HashSet<Clanarina>();
        }

        public int Id { get; set; }
        public string BrojTelefona { get; set; }
        public int KorisnikId { get; set; }
        public string Dijagnoza { get; set; }

        public virtual KorisniciSistema Korisnik { get; set; }
        public virtual ICollection<Clanarina> Clanarinas { get; set; }
    }
}
