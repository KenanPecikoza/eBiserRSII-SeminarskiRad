using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class KorisniciSistema
    {
        public KorisniciSistema()
        {
            Clanovis = new HashSet<Clanovi>();
            Donacijes = new HashSet<Donacije>();
            Donatoris = new HashSet<Donatori>();
            ObavijestOcjenas = new HashSet<ObavijestOcjena>();
            Osobljes = new HashSet<Osoblje>();
        }

        public int KorisnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public bool Verifikovan { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Ime { get; set; }
        public byte[] Photo { get; set; }
        public byte[] PhotoThumb { get; set; }
        public string Prezime { get; set; }
        public int KorisnikSistemaTipId { get; set; }

        public virtual KorisnikSistemaTip KorisnikSistemaTip { get; set; }
        public virtual ICollection<Clanovi> Clanovis { get; set; }
        public virtual ICollection<Donacije> Donacijes { get; set; }
        public virtual ICollection<Donatori> Donatoris { get; set; }
        public virtual ICollection<ObavijestOcjena> ObavijestOcjenas { get; set; }
        public virtual ICollection<Osoblje> Osobljes { get; set; }
    }
}
