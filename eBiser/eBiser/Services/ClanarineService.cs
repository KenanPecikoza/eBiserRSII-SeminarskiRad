using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class ClanarineService : BaseCRUDService<Data.Clanarina, ClanarinaSearchRequest, Clanarina, ClanarinaUpsertRequest, ClanarinaUpsertRequest>
    {
        public ClanarineService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.Clanarina> Get(ClanarinaSearchRequest search)
        {
            var query = _db.Clanarinas.Include(x=> x.Clan).ThenInclude(x=> x.Korisnik).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Clan.Korisnik.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Clan.Korisnik.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            if (search.Mjesec > 0 )
            {
                query = query.Where(x => x.Mjesec == search.Mjesec);
            }
            if (search.Godina > 0)
            {
                query = query.Where(x => x.Godina == search.Godina);
            }
            if (search.ClanId > 0)
            {
                query = query.Where(x => x.ClanId == search.ClanId);

            }
            var list = query.ToList();
            return _mapper.Map<List<Data.Clanarina>>(list);
        }
        public override Data.Clanarina GetbyId(int id)
        {
            var clanarina = _db.Clanarinas.Include(x => x.Clan).ThenInclude(x => x.Korisnik).Where(x=> x.Id==id).FirstOrDefault();
            return _mapper.Map<Data.Clanarina>(clanarina);

        }
    }
}

