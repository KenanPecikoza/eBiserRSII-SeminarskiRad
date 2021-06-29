using eBiser.Data;
using eBiser.Data.Requests;
using eBiser.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    public class ObavijestOcjenaController : BaseCRUDCrudcontroller<Data.ObavijestOcjena, ObavijestOcjenaSearchRequest, ObavijestOcjenaUpsertRequest, ObavijestOcjenaUpsertRequest>
    {
        public ObavijestOcjenaController(ICRUDService<ObavijestOcjena, ObavijestOcjenaSearchRequest, ObavijestOcjenaUpsertRequest, ObavijestOcjenaUpsertRequest> Service) : base(Service)
        {
        }
    }
}
