using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class DonacijeUpsertRequest
    {
        [Required]
        [MinLength(2)]
        public string Naziv { get; set; }
        [Required]
        public int KorisniciSistemaId { get; set; }
        [Required]
        [MinLength(2)]
        public string OpisDonacije { get; set; }
        public bool Prihvacena { get; set; }
        public bool Odbijena { get; set; }
        public string Obrazlozenje { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdgovra { get; set; }
        public bool NaCekanju { get; set; }
    }
}
