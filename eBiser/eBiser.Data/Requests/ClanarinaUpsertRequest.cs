using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ClanarinaUpsertRequest
    {
        [Required]
        public int Godina { get; set; }
        [Required]
        public int Mjesec { get; set; }
        [Required]
        public double Iznos { get; set; }
        [Required]
        public DateTime DatumUplate { get; set; }
        [Required]
        public int ClanId { get; set; }
    }
}
