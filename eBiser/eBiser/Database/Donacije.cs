using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Donacije
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KorisniciSistemaId { get; set; }
        public string OpisDonacije { get; set; }
        public bool Prihvacena { get; set; }
        public string Obrazlozenje { get; set; }
        public DateTime DatumOdgovra { get; set; }
        public DateTime DatumPrijave { get; set; }
        public bool? NaCekanju { get; set; }
        public bool? Odbijena { get; set; }

        public virtual KorisniciSistema KorisniciSistema { get; set; }
    }
}
