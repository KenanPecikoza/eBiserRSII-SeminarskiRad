using eBiser.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    public class ObavijestKategorija : BaseController<Data.ObavijestKategorija, object>
    {
        public ObavijestKategorija(IService<Data.ObavijestKategorija, object> Service) : base(Service)
        {
        }
    }
}
