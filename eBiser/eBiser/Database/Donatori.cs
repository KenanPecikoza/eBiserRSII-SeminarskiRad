using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Donatori
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public string OpisProfila { get; set; }
        public string BrojTelefona { get; set; }

        public virtual KorisniciSistema Korisnik { get; set; }
    }
}
