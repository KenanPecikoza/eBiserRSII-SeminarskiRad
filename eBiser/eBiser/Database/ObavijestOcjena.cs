using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class ObavijestOcjena
    {
        public int Id { get; set; }
        public int Ocjena { get; set; }
        public int ObavijestId { get; set; }
        public int KorisniciSistemaId { get; set; }
        public DateTime DatumOcjene { get; set; }

        public virtual KorisniciSistema KorisniciSistema { get; set; }
        public virtual Obavijesti Obavijest { get; set; }
    }
}
