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
    public class DonacijeService : BaseCRUDService<Data.Donacije, DonacijeSearchRequest, Donacije, DonacijeUpsertRequest, DonacijeUpsertRequest>
    {
        public DonacijeService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override Data.Donacije GetbyId(int id)
        {
            var entity = _db.Donacijes.Include(x => x.KorisniciSistema).FirstOrDefault(x => x.Id == id);
            return _mapper.Map<Data.Donacije>(entity);
        }
        public override List<Data.Donacije> Get(DonacijeSearchRequest search)
        {
            var query = _db.Donacijes.Include(x => x.KorisniciSistema).AsQueryable();
            if (search.KorisnikSistemaId>0)
            {
                query = query.Where(x => x.KorisniciSistemaId == search.KorisnikSistemaId);

            }
            if (!string.IsNullOrWhiteSpace( search.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().IndexOf(search.Naziv.ToLower()) != -1);
            }
            if (!string.IsNullOrWhiteSpace(search.OpisDonacije))
            {
                query = query.Where(x => x.OpisDonacije.ToLower().IndexOf(search.OpisDonacije.ToLower()) != -1);
            }
            if (search?.DatumPrijave != null)
            {
                query = query.Where(x => x.DatumPrijave <= search.DatumPrijave);
            }

            var list = _mapper.Map<List<Data.Donacije>>(query.ToList());
            return _mapper.Map<List<Data.Donacije>>(list);
        }
    }
}
