using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class IzlaznaSredstvaUpsertRequest
    {
        public IzlaznaSredstvaUpsertRequest()
        {
            Fotografije = new List<byte[]>();
        }
        [Required]
        [MinLength(2)]
        public string Naslov { get; set; }
        [Required]
        public int  OsobljeId { get; set; }
        [Required]
        public double Količina { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        [MinLength(2)]
        public string Opis { get; set; }
        public List<byte[]> Fotografije { get; set; }
    }
}
