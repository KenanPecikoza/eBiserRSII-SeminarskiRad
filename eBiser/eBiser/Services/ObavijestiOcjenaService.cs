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
    public class ObavijestiOcjenaService : BaseCRUDService<Data.ObavijestOcjena, ObavijestOcjenaSearchRequest, ObavijestOcjena, ObavijestOcjenaUpsertRequest, ObavijestOcjenaUpsertRequest>    {
        public ObavijestiOcjenaService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.ObavijestOcjena> Get(ObavijestOcjenaSearchRequest search)
        {
            var query = _db.ObavijestOcjenas.Include(x=> x.KorisniciSistema).AsQueryable();
            if (search.KorisnikId>0 )
            {
                query = query.Where(x => x.KorisniciSistemaId == search.KorisnikId);
            }
            if ( search.ObavijestId > 0)
            {
                query = query.Where(x => x.ObavijestId == search.ObavijestId);
            }




            var list = query.ToList();
            return _mapper.Map<List<Data.ObavijestOcjena>>(list);
        }
        public override Data.ObavijestOcjena GetbyId(int id)
        {
            var entity = _db.ObavijestOcjenas.Include(x=> x.KorisniciSistema).FirstOrDefault(x=> x.Id==id);
            return _mapper.Map<Data.ObavijestOcjena>(entity);
        }
    }
}
