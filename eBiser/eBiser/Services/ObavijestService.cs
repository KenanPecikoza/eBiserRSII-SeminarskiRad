using AutoMapper;
using eBiser.Data;
using eBiser.Data.Requests;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class ObavijestService : BaseCRUDService<Data.Obavijest, ObavijestSearchRequest, Database.Obavijesti, ObavijestInsertRequest, ObavijestInsertRequest>
    {
        public ObavijestService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.Obavijest> Get(ObavijestSearchRequest search)
        {
            var query = _db.Obavijestis.Include(x=> x.Kategorija).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.PretragaPoSadrzaju))
            {
                query = query.Where(x => x.Sadržaj.ToLower().IndexOf(search.PretragaPoSadrzaju.ToLower())!=-1);
            }  
            if (!string.IsNullOrWhiteSpace(search?.PretragaPoNaslovu))
            {
                query = query.Where(x => x.Naslov.ToLower().IndexOf(search.PretragaPoNaslovu.ToLower())!=-1);
            }
            if (search?.PretragaPoDatumuOd!=null)
            {
                query = query.Where(x =>x.VrijediDo>=search.PretragaPoDatumuOd);
            }
            if (search?.PretragaPoDatumuDo!=null)
            {
                query = query.Where(x =>x.VrijediDo<=search.PretragaPoDatumuDo);
            }
            if (search?.KategorijaId!= null)
            {
                query = query.Where(x=> x.KategorijaId==search.KategorijaId);
            }
            var list = _mapper.Map<List<Data.Obavijest>>(query.ToList());
            
            foreach (var i in list)
            {
                i.Fotografije = _db.ObavijestPhotos.Where(x => x.ObavijestId == i.Id).Select(x => x.Photo).ToList();
                var ocjene = _db.ObavijestOcjenas.Where(x => x.ObavijestId == i.Id).Select(x => x.Ocjena);
                if (ocjene.Count()>0)
                {
                    i.Ocjena = Int32.Parse(Math.Ceiling(ocjene.Average()).ToString());
                }
            }
            return list;
        }
        public override Data.Obavijest GetbyId(int id)
        {
            var entity = _mapper.Map<Data.Obavijest>(_db.Obavijestis.Find(id));
            entity.Fotografije = _db.ObavijestPhotos.Include(x=> x.Obavijest).ThenInclude(x=> x.Kategorija).Where(x => x.ObavijestId == id).Select(x=> x.Photo).ToList();
            if (_db.ObavijestOcjenas.Where(x => x.ObavijestId == entity.Id).Count()>0)
            {
                 entity.Ocjena = Int32.Parse(Math.Ceiling(_db.ObavijestOcjenas.Where(x => x.ObavijestId == entity.Id).Average(x => x.Ocjena)).ToString());
            }
            else
            {
                entity.Ocjena = 0;
            }

            return entity;
        }

        public override Data.Obavijest Insert(ObavijestInsertRequest request)
        {
            var entity = _mapper.Map<Database.Obavijesti>(request);
            entity.OsobljeId = 1;// izvući id objavljivača iz http 
            _db.Add(entity);
            _db.SaveChanges();
            foreach (var i in request.Fotografije)
            {
                _db.Add(new ObavijestPhoto
                {
                    ObavijestId = entity.Id,
                    Photo= i
                });     
            }
            _db.SaveChanges();
            return _mapper.Map<Data.Obavijest>(entity);
        }
        public override Data.Obavijest Update(int id, ObavijestInsertRequest request)
        {

            var entity = _db.Obavijestis.Find(id);
            _mapper.Map(request, entity);
            _db.SaveChanges();
            var photo = _db.ObavijestPhotos.Where(x => x.ObavijestId == id).ToList();
            if (request.Fotografije.Count > 0 && photo.Count > 0)
            {
                foreach (var i in photo)
                {
                    _db.Remove(i);
                }
                _db.SaveChanges();
            }
            foreach (var i in request.Fotografije)
            {
                _db.Add(new ObavijestPhoto
                {
                    ObavijestId = entity.Id,
                    Photo = i
                });
            }
            _db.SaveChanges();
            return _mapper.Map<Data.Obavijest>(entity);
        }

    }
}
