using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class IzlaznaSredstvaService : BaseCRUDService<Data.IzlaznaSredstva, IzlaznaSredstvaSearchRequest, IzlaznaSredstva, IzlaznaSredstvaUpsertRequest, IzlaznaSredstvaUpsertRequest>
    {
        public IzlaznaSredstvaService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.IzlaznaSredstva> Get(IzlaznaSredstvaSearchRequest search)
        {
            var query = _db.IzlaznaSredstvas.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naslov.ToLower().IndexOf(search.Naziv.ToLower()) != -1);
            }
            if (!string.IsNullOrWhiteSpace(search?.Opis))
            {
                query = query.Where(x => x.Opis.ToLower().IndexOf(search.Opis.ToLower()) != -1);
            }
            if (search.Mjesec > 0)
            {
                query = query.Where(x => x.Datum.Month == search.Mjesec);
            }
            if (search.Godina > 0)
            {
                query = query.Where(x => x.Datum.Year == search.Godina);
            }
            var list = _mapper.Map<List<Data.IzlaznaSredstva>>(query.ToList());
            foreach (var i in list)
            {
                i.Fotografije = _db.IzlaznaSredstvaPhotos.Where(x => x.IzlaznaSredstvaId == i.Id).Select(x => x.Photo).ToList();
            }
            return list;
        }
        public override Data.IzlaznaSredstva GetbyId(int id)
        {
            var entity = _mapper.Map<Data.IzlaznaSredstva>(_db.IzlaznaSredstvas.Find(id));
            entity.Fotografije = _db.IzlaznaSredstvaPhotos.Where(x => x.IzlaznaSredstvaId == id).Select(x => x.Photo).ToList();
            return entity;
        }
        public override Data.IzlaznaSredstva Insert(IzlaznaSredstvaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.IzlaznaSredstva>(request);
            _db.Add(entity);
            _db.SaveChanges();
            foreach (var i in request.Fotografije)
            {
                _db.Add(new IzlaznaSredstvaPhoto
                {
                    IzlaznaSredstvaId = entity.Id,
                    Photo = i
                });
            }
            _db.SaveChanges();
            return _mapper.Map<Data.IzlaznaSredstva>(entity);
        }
        public override Data.IzlaznaSredstva Update(int id, IzlaznaSredstvaUpsertRequest request)
        {

            var entity = _db.IzlaznaSredstvas.Find(id);
            _mapper.Map(request, entity);
            _db.SaveChanges();
            var photo= _db.IzlaznaSredstvaPhotos.Where(x => x.IzlaznaSredstvaId == id).ToList();
            if (request.Fotografije.Count>0&& photo.Count>0)
            {
                foreach (var i in photo)
                {
                    _db.Remove(i);
                }
             _db.SaveChanges();
            }
            foreach (var i in request.Fotografije)
            {
                _db.Add(new IzlaznaSredstvaPhoto
                {
                    IzlaznaSredstvaId = entity.Id,
                    Photo = i
                });
            }
            _db.SaveChanges();
            return _mapper.Map<Data.IzlaznaSredstva>(entity);
        }
    }
}

