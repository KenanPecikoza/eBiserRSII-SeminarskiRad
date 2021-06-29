using eBiser.Data;
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
    public class ObavijestController : BaseCRUDCrudcontroller<Data.Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest>
    {
        public ObavijestController(ICRUDService<Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest> Service) : base(Service)
        {
        }
    }
}
