using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class KorisniciSistema
    {
        public int KorisnikId { get; set; }
        public int Id { get; set; }
        public int KorisnikSistemaTipId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Photo { get; set; }
        public byte[] PhotoThumb { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public bool Verifikovan { get; set; }
        public string Token { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string ImeIPrezime { get; set; }

    }
    public class OsobljeDTO :KorisniciSistema
    {
        public string NazivDjelatnosti { get; set; }
        public int DjelatnostId { get; set; }
        public DateTime DatumPocetkaAngazmana { get; set; }
    }
    public class DonatorDTO : KorisniciSistema
    {
        public string BrojTelefona { get; set; }
        public string OpisProfila { get; set; }
    }
    public class ClanDTO : KorisniciSistema
    {
        public string Dijagnoza { get; set; }
        public string BrojTelefona { get; set; }
        public string Clanarine { get; set; }

    }

}
