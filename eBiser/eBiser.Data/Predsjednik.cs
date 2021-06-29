using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class Predsjednik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ClanId { get; set; }
        public DateTime DatumImenovanja { get; set; }
        public bool Aktivan { get; set; }
    }
}
