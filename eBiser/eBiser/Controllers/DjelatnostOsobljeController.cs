using eBiser.Data;
using eBiser.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    [Authorize(Roles = "Osoblje")]
    public class DjelatnostOsobljeController : BaseController<Data.DjelatnostOsoblje, object>
    {
        public DjelatnostOsobljeController(IService<DjelatnostOsoblje, object> Service) : base(Service)
        {
        }
    }
}
