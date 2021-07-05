using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ProjektiUpsertRequest
    {
        [Required]
        public string NazivProjekta { get; set; }
        [Required]
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumIzvrsenja { get; set; }
        public bool Prihvaćen { get; set; }
        [Required]
        public double CijenaProjekta { get; set; }
        public double OdobrenaSredstva { get; set; }
        public string RokIzvrsenja { get; set; }
        [Required]
        public int OsobljeId { get; set; }
    }
}
