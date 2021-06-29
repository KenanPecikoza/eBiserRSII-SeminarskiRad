﻿using eBiser.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDCrudcontroller<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service=null;
        public BaseCRUDCrudcontroller(ICRUDService<T, TSearch, TInsert, TUpdate> Service) : base(Service)
        {
            _service = Service;
        }
        [Authorize]
        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [Authorize]
        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}
