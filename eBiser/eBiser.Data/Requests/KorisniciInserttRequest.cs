using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class KorisniciInserttRequest
    {
        [Required]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required]
        [MinLength(2)]
        public string Prezime { get; set; }
        public byte[] Photo { get; set; }
        public byte[] PhotoThumb { get; set; }
        [Required]
        [MinLength(2)]
        public string KorisnickoIme { get; set; }
        //[Required]
        [RegularExpression(@"(?=.*[a-z])(?=.*[A-Z])(?=.+\d)(?=.*[!@#$%^&*()_+=\[{\]};:<>|.?,-]).{8,}$", ErrorMessage = "Password ne odgovara")]
        public string Password{ get; set; }
        [Required]
        public string PasswordPotvrda { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public bool Verifikovan { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }

        public class OsobljeUpsertRequest : KorisniciInserttRequest
        {
            public int DjelatnostId { get; set; }
            [Required]

            public DateTime DatumPocetkaAngazmana { get; set; }
        }
        public class DonatorUpsertRequest : KorisniciInserttRequest
        {
            [Required]
            [MinLength(2)]
            public string OpisProfila { get; set; }
            [Required]
            [RegularExpression(@"[0-9]\d{2}\d{3}\d{3,4}", ErrorMessage = "Broj telefona ne odgovara")]
            public string BrojTelefona { get; set; }

        }
        public class ClanUpsertRequest : KorisniciInserttRequest
        {
            [Required]
            [RegularExpression(@"[0-9]\d{2}\d{3}\d{3,4}", ErrorMessage = "Broj telefona ne odgovara")]
            public string BrojTelefona { get; set; }

            [Required]
            [MinLength(2)]
            public string Dijagnoza { get; set; }
        }


    }
}
