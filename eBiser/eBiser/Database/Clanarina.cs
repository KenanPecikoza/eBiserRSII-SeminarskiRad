using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Clanarina
    {
        public int Id { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
        public int ClanId { get; set; }

        public virtual Clanovi Clan { get; set; }
    }
}
