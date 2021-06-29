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
    [Authorize(Roles = "Osoblje,Clan")]
    public class ClanarinaController : BaseCRUDCrudcontroller<Clanarina, ClanarinaSearchRequest, ClanarinaUpsertRequest, ClanarinaUpsertRequest>
    {
        public ClanarinaController(ICRUDService<Clanarina, ClanarinaSearchRequest, ClanarinaUpsertRequest, ClanarinaUpsertRequest> Service) : base(Service)
        {
        }
        
    }
}
