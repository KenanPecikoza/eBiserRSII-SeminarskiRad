using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class AkcijePomociUpsertRequest
    {
        [Required]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required]
        [MinLength(2)]
        public string Prezime { get; set; }
        [Required]
        public double TraženaCifra { get; set; }
        [Required]
        public double Skupljeno { get; set; }
        public bool Aktivno { get; set; }
        public byte[] Fotografija{ get; set; }
    }
}
