using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class KorisnikSistemaTip
    {
        public KorisnikSistemaTip()
        {
            KorisniciSistemas = new HashSet<KorisniciSistema>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<KorisniciSistema> KorisniciSistemas { get; set; }
    }
}
