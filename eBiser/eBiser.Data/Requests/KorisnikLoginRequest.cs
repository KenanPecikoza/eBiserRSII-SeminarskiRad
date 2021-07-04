using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class KorisnikLoginRequest
    {
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
