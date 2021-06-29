using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ObavijestOcjenaUpsertRequest
    {

        [Required]
        public int Ocjena { get; set; }
        [Required]
        public int ObavijestId { get; set; }
        [Required]
        public int KorisniciSistemaId { get; set; }
        [Required]
        public DateTime DatumOcjene { get; set; }
    }
}
