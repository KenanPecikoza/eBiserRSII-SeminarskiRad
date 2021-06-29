using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class UlaznaSredstvaUpsertRequest
    {
        public UlaznaSredstvaUpsertRequest()
        {
            Fotografije = new List<byte[]>();
        }

        [Required]
        public double Količina { get; set; }
        [Required]
        public int OsobljeId { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        [MinLength(2)]
        public string Opis { get; set; }
        [Required]
        [MinLength(2)]
        public string Naslov { get; set; }
        public List<byte[]> Fotografije { get; set; }

    }
}
