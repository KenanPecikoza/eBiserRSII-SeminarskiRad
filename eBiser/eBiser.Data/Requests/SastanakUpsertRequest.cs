using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class SastanakUpsertRequest
    {
        [Required]
        public DateTime DatumOdrzavanja { get; set; }
        public string Zapisnik { get; set; }
        [Required]
        public int OsobljeId { get; set; }
        public bool Odrzan { get; set; }
        public bool Zakazan { get; set; }
        [Required]
        public string Naslov { get; set; }
    }
}
