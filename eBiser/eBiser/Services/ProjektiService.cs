using AutoMapper;
using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;

namespace eBiser.Services
{
    public class ProjektiService : BaseCRUDService<Data.Projekti, ProjektiSearchRequest, Database.Projekti, ProjektiUpsertRequest, ProjektiUpsertRequest>
    {
        public ProjektiService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.Projekti> Get(ProjektiSearchRequest search)
        {
            var query = _db.Projektis.Include(x => x.Osoblje).ThenInclude(x=> x.Korisnik).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.NazivProjekta))
            {
                query = query.Where(x => x.NazivProjekta.ToLower().IndexOf(search.NazivProjekta.ToLower()) != -1);
            }
            if (search?.DatumPrijave != null)
            {
                query = query.Where(x => x.DatumPrijave == search.DatumPrijave.Value.Date);
            }
            if (search?.DatumPrijave != null)
            {
                query = query.Where(x => x.DatumIzvrsenja == search.DatumIzvrsenja.Value.Date);
            }
            if (search?.Prihvaćen != null)
            {
                query = query.Where(x => x.Prihvaćen == search.Prihvaćen);
            }
            var list = query.ToList();

            return _mapper.Map<List<Data.Projekti>>(list);
        }
    }
}
