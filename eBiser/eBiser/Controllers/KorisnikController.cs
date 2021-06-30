using eBiser.Data.Requests;
using eBiser.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static eBiser.Data.Requests.KorisniciInserttRequest;
using static eBiser.Data.Requests.KorisniciSearchRequest;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiser.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;
        public KorisnikController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }
        [Authorize(Roles = "Osoblje")]
        [HttpGet]
        public IActionResult Get([FromQuery] KorisniciSearchRequest search)
        {
            return Ok(_korisniciService.Get(search));
        }

        //[Authorize(Roles = "Osoblje")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_korisniciService.GetById(id));
        }

        [Authorize(Roles = "Donator,Osoblje")]
        [HttpGet("donatori/{id}")]
        public IActionResult GetDonator(int id)
        {
            return Ok(_korisniciService.GetDonator(id));
        }
        [Authorize(Roles = "Osoblje")]

        [HttpGet("donatori")]
        public IActionResult GetDonatori([FromQuery] KorisniciSearchRequest search)
        {
            return Ok(_korisniciService.GetDonatori(search));
        }

        [Authorize(Roles = "Clan,Osoblje")]
        [HttpGet("clan/{id}")]
        public IActionResult GetClan(int id)
        {
            return Ok(_korisniciService.GetClan(id));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpGet("clan")]
        public IActionResult GetClanovi([FromQuery] KorisniciSearchRequest search)
        {
            return Ok(_korisniciService.GetCLanovi(search));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpGet("osoblje/{id}")]
        public IActionResult GetOsoblje(int id)
        {
            return Ok(_korisniciService.GetOsoblje(id));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpGet("osoblje")]
        public IActionResult GetOsoblje([FromQuery] OsobljeSearchRequest search)
        {
            return Ok(_korisniciService.GetOsoblje(search));
        }

        [Authorize(Roles = "Donator,Osoblje")]
        [HttpPost("donatori")]
        public IActionResult Insert([FromBody] DonatorUpsertRequest request)
        {
            return Ok(_korisniciService.Insert(request));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpPost("clan")]
        public IActionResult Insert([FromBody] ClanUpsertRequest request)
        {
            return Ok(_korisniciService.Insert(request));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpPost("osoblje")]
        public IActionResult Insert([FromBody] OsobljeUpsertRequest request)
        {
            return Ok(_korisniciService.Insert(request));
        }

        [Authorize(Roles = "Donator,Osoblje")]
        [HttpPut("donatori/{id}")]
        public IActionResult Update(int id, [FromBody] DonatorUpdateRequest request)
        {
            return Ok(_korisniciService.Update(id, request));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpPut("clan/{id}")]
        public IActionResult Update(int id, [FromBody] ClanUpdateRequest request)
        {
            return Ok(_korisniciService.Update(id, request));
        }
        [Authorize(Roles = "Osoblje")]
        [HttpPut("osoblje/{id}")]
        public IActionResult Update(int id, [FromBody] OsobljeUpdateRequest request)
        {
            return Ok(_korisniciService.Update(id, request));
        }






    }
}
