using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class BaseService<TModel, TSerach, TDatabase> : IService<TModel,TSerach> where TDatabase :class
    {
        protected readonly eBiserContext _db;
        protected readonly IMapper _mapper;
        public BaseService(eBiserContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSerach search)
        {
            var list = _db.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetbyId(int id)
        {
            var entity = _db.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
