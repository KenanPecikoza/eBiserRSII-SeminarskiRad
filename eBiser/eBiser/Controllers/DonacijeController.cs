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
    public class DonacijeController : BaseCRUDCrudcontroller<Data.Donacije, DonacijeSearchRequest, DonacijeUpsertRequest, DonacijeUpsertRequest>
    {
        public DonacijeController(ICRUDService<Donacije, DonacijeSearchRequest, DonacijeUpsertRequest, DonacijeUpsertRequest> Service) : base(Service)
        {
        }
    }
}
