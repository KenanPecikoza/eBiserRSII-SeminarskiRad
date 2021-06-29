using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public interface ISecurityService
    {
        Data.KorisniciSistema Login(KorisnikLoginRequest loginRequest);
        Data.KorisniciSistema RestartPassword(int id,RestartPasswordRequest restartPasswordRequest);
    }
}
