using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class Clanarina
    {
        public int Id { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeIPrezime { get; set; }
    }
}
