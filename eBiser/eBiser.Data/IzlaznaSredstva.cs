using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class IzlaznaSredstva
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public double Količina { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public List<byte[]> Fotografije { get; set; }

    }
}
