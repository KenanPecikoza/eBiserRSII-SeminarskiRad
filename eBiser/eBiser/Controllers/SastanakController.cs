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

    public class SastanakController : BaseCRUDCrudcontroller<Data.Sastanak, SastanakSearchRequest, SastanakUpsertRequest, SastanakUpsertRequest>
    {
        public SastanakController(ICRUDService<Sastanak, SastanakSearchRequest, SastanakUpsertRequest, SastanakUpsertRequest> Service) : base(Service)
        {
        }
    }
}
