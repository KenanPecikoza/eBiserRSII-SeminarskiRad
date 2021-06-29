using eBiser.Data;
using eBiser.Data.Requests;
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

    public class ProjektiController : BaseCRUDCrudcontroller<Data.Projekti, ProjektiSearchRequest, ProjektiUpsertRequest, ProjektiUpsertRequest>
    {
        public ProjektiController(ICRUDService<Projekti, ProjektiSearchRequest, ProjektiUpsertRequest, ProjektiUpsertRequest> Service) : base(Service)
        {
        }
    }
}
