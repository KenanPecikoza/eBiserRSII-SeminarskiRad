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
    public class AkcijePomociController : BaseCRUDCrudcontroller<Data.AkcijePomoci, AkcijePomociSearchRequest, AkcijePomociUpsertRequest, AkcijePomociUpsertRequest>
    {
        public AkcijePomociController(ICRUDService<Data.AkcijePomoci, AkcijePomociSearchRequest, AkcijePomociUpsertRequest, AkcijePomociUpsertRequest> Service) : base(Service)
        {
        }
    }
}
