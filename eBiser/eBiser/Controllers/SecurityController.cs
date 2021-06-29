using eBiser.Data.Requests;
using eBiser.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;

        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;
        }



        [HttpPost()]
        public Data.KorisniciSistema Login([FromBody] KorisnikLoginRequest request)
        {
            return _securityService.Login(request);
        }

        [HttpPut("{id}")]

        public Data.KorisniciSistema RestartPassword(int id,[FromBody] RestartPasswordRequest request)
        {
            return _securityService.RestartPassword(id,request);
        }

    }
}
