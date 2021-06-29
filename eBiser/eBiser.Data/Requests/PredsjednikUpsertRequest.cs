using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class PredsjednikUpsertRequest
    {

        //public Clan Clan { get; set; }
        [Required]
        public int ClanId { get; set; }
        [Required]
        public DateTime DatumImenovanja { get; set; }
        [Required]
        public bool Aktivan { get; set; }
    }
}
