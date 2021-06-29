using eBiser.Data;
using eBiser.Data.Requests;
using eBiser.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    [Authorize(Roles = "Osoblje")]

    public class UlaznaSredstvaController : BaseCRUDCrudcontroller<Data.UlaznaSredstva, UlaznaSredstvaSearchRequest, UlaznaSredstvaUpsertRequest, UlaznaSredstvaUpsertRequest>
    {
        public UlaznaSredstvaController(ICRUDService<UlaznaSredstva, UlaznaSredstvaSearchRequest, UlaznaSredstvaUpsertRequest, UlaznaSredstvaUpsertRequest> Service) : base(Service)
        {
        }
    }
}
