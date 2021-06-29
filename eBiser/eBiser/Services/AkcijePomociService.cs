using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class AkcijePomociService : BaseCRUDService<Data.AkcijePomoci, AkcijePomociSearchRequest, AkcijePomoci, AkcijePomociUpsertRequest, AkcijePomociUpsertRequest>
    {
        public AkcijePomociService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.AkcijePomoci> Get(AkcijePomociSearchRequest search)
        {

            var query = _db.AkcijePomocis.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            //query = query.Where(x => x.Aktivno == search.Aktivno);
            var list = query.ToList();
            return _mapper.Map<List<Data.AkcijePomoci>>(list);
        }
        public override Data.AkcijePomoci Insert(AkcijePomociUpsertRequest request)
        {
            var entity = _mapper.Map<AkcijePomoci>(request);
            entity.OsobljeId = 1;
            _db.Add(entity);
            _db.SaveChanges();
            return _mapper.Map<Data.AkcijePomoci>(entity);
        }

    }
}
