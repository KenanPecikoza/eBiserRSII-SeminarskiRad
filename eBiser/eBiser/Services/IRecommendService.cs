using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public interface IRecommendService
    {
        List<Data.Obavijest> RecommendProduct(int id);

    }
}
