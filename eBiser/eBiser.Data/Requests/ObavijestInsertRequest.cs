using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ObavijestInsertRequest
    {
        public ObavijestInsertRequest()
        {
            Fotografije = new List<byte[]>();
        }
        [Required]
        public DateTime DatumObjave { get; set; }
        [Required]
        public DateTime VrijediDo { get; set; }
        [Required]
        public bool Aktivna { get; set; }
        [Required]
        public int OsobljeId { get; set; }
        [Required]
        [MinLength(2)]
        public string Sadržaj { get; set; }
        [Required]
        [MinLength(2)]
        public string Naslov { get; set; }
        public List<byte[]> Fotografije{ get; set; }
        [Required]
        public int KategorijaId { get; set; }
    }
}


