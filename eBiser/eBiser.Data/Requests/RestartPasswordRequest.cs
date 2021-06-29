using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class RestartPasswordRequest
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordPotvrda { get; set; }
    }
}
