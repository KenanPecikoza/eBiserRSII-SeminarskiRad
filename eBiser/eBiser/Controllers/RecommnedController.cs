using eBiser.Data;
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
    public class RecommnedController : ControllerBase
    {
        public IRecommendService _service { get; set; }
        public RecommnedController(IRecommendService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public IActionResult RecommendProduct(int id)
        {
            return Ok( _service.RecommendProduct(id));
        }

    }
}
