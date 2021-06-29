using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public interface IService<T,TSearch>
    { 
        List<T> Get(TSearch search);
        T GetbyId(int id);

        
    }
}
