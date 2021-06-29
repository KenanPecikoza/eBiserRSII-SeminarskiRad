using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class SastanakService : BaseCRUDService<Data.Sastanak, SastanakSearchRequest, Sastanak, SastanakUpsertRequest, SastanakUpsertRequest>
    {
        public SastanakService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.Sastanak> Get(SastanakSearchRequest search)
        {
            var query = _db.Sastanaks.Include(x => x.Osoblje).ThenInclude(x=> x.Korisnik).AsQueryable();
            if (search.Dan > 0)
            {
                query = query.Where(x => x.DatumOdrzavanja.Day == search.Dan);
            }
            if (search.Mjesec > 0)
            {
                query = query.Where(x => x.DatumOdrzavanja.Month== search.Mjesec);
            }
            if (search.Godina > 0)
            {
                query = query.Where(x => x.DatumOdrzavanja.Year == search.Godina);
            }
            if (search.Datum!=null)
            {
                query = query.Where(x => x.DatumOdrzavanja == search.Datum);
            }
            var list = query.ToList();
            return _mapper.Map<List<Data.Sastanak>>(list);
        }
        public override Data.Sastanak GetbyId(int id)
        {
            var entity = _db.Sastanaks.Include(x => x.Osoblje).ThenInclude(x => x.Korisnik).FirstOrDefault(x=> x.Id==id);  
            return _mapper.Map<Data.Sastanak>(entity);
        }
    }
}
