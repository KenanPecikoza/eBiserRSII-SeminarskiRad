using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class Donacije
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string ImeDonatora { get; set; }
        public string PrezimeDonatora { get; set; }
        public string ImeIPrezimeDonatora { get; set; }
        public string OpisDonacije { get; set; }
        public bool Prihvacena { get; set; }
        public bool Odbijena { get; set; }
        public bool NaCekanju { get; set; }
        public string Obrazlozenje { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdgovra { get; set; }
        public int KorisniciSistemaId { get; set; }

    }
}
