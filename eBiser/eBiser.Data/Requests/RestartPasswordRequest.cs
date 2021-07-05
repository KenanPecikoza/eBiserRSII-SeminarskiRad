using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiser.Data.Requests
{
    public class RestartPasswordRequest
    {
        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"(?=.*[a-z])(?=.*[A-Z])(?=.+\d)(?=.*[!@#$%^&*()_+=\[{\]};:<>|.?,-]).{8,}$", ErrorMessage = "Password ne odgovara")]
        public string NewPassword { get; set; }
        [Required]
        [RegularExpression(@"(?=.*[a-z])(?=.*[A-Z])(?=.+\d)(?=.*[!@#$%^&*()_+=\[{\]};:<>|.?,-]).{8,}$", ErrorMessage = "Password ne odgovara")] 
        public string NewPasswordPotvrda { get; set; }
    }
}
