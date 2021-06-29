using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class UlaznaSredstvaService : BaseCRUDService<Data.UlaznaSredstva, UlaznaSredstvaSearchRequest, UlaznaSredstva, UlaznaSredstvaUpsertRequest, UlaznaSredstvaUpsertRequest>
    {
        public UlaznaSredstvaService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Data.UlaznaSredstva> Get(UlaznaSredstvaSearchRequest search)
        {
            var query = _db.UlaznaSredstvas.AsQueryable();
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
            var list = _mapper.Map<List<Data.UlaznaSredstva>>(query.ToList());
            foreach (var i in list)
            {
                i.Fotografije = _db.UlaznaSredstvaPhotos.Where(x => x.UlaznaSredstvaId == i.Id).Select(x => x.Photo).ToList();
            }
            return list;
        }
        public override Data.UlaznaSredstva GetbyId(int id)
        {
            var entity = _mapper.Map<Data.UlaznaSredstva>(_db.UlaznaSredstvas.Find(id));
            entity.Fotografije = _db.UlaznaSredstvaPhotos.Where(x => x.UlaznaSredstvaId == id).Select(x => x.Photo).ToList();
            return entity;
        }
        public override Data.UlaznaSredstva Insert(UlaznaSredstvaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.UlaznaSredstva>(request);
            _db.Add(entity);
            _db.SaveChanges();
            foreach (var i in request.Fotografije)
            {
                _db.Add(new UlaznaSredstvaPhoto
                {
                    UlaznaSredstvaId = entity.Id,
                    Photo = i
                });
            }
            _db.SaveChanges();
            return _mapper.Map<Data.UlaznaSredstva>(entity);
        }
        public override Data.UlaznaSredstva Update(int id, UlaznaSredstvaUpsertRequest request)
        {

            var entity = _db.UlaznaSredstvas.Find(id);
            _mapper.Map(request, entity);
            _db.SaveChanges();
            var photo = _db.UlaznaSredstvaPhotos.Where(x => x.UlaznaSredstvaId == id).ToList();
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
                _db.Add(new UlaznaSredstvaPhoto
                {
                    UlaznaSredstvaId = entity.Id,
                    Photo = i
                });
            }
            _db.SaveChanges();
            return _mapper.Map<Data.UlaznaSredstva>(entity);
        }
    }
}
