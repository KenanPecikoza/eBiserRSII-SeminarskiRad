using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class ObavijestOcjena
    {
        public int Id { get; set; }
        public int Ocjena { get; set; }
        public int ObavijestId { get; set; }
        public int KorisniciSistemaId { get; set; }
        public string ImeiPrezime { get; set; }
        public DateTime DatumOcjene { get; set; }
    }
}
