using AutoMapper;
using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiser.Database;

namespace eBiser.Services
{
    public class ProjektiService : BaseCRUDService<Data.Projekti, ProjektiSearchRequest, Database.Projekti, ProjektiUpsertRequest, ProjektiUpsertRequest>
    {
        public ProjektiService(eBiserContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
