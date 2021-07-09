using AutoMapper;
using eBiser.Data;
using eBiser.Database;
using eBiser.ML;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public class RecommendService : IRecommendService
    {
        static MLContext mlContext = null;
        static ITransformer model = null;
        protected eBiserContext _db;
        protected IMapper _mapper;

        public RecommendService(eBiserContext db, IMapper mapper) 
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Obavijest> RecommendProduct(int id)
        {

            var tempData = _db.Obavijestis.Where(x => x.Id == id).FirstOrDefault(); ;
            var tempdataObavijest1= _mapper.Map<List<Obavijest>>( _db.Obavijestis.Include(x=> x.ObavijestOcjenas).Include(x=> x.Kategorija).Where(x=> x.Id!=id && x.KategorijaId==tempData.KategorijaId).ToList());

            foreach (var i in tempdataObavijest1)
            {
                i.Fotografije = _db.ObavijestPhotos.Where(x => x.ObavijestId == i.Id).Select(x => x.Photo).ToList();
                var ocjene = _db.ObavijestOcjenas.Where(x => x.ObavijestId == i.Id).Select(x => x.Ocjena);
                if (ocjene.Count() > 0)
                {
                    i.Ocjena = Int32.Parse(Math.Ceiling(ocjene.Average()).ToString());
                }
            }
            var tempdataObavijest= _mapper.Map<List<Obavijest>>(tempdataObavijest1.Where(x=> x.Ocjena>3));
            if (mlContext == null)
            {
                mlContext = new MLContext();
                var relatedItems = new List<ProductEntry>();

                foreach (var o in tempdataObavijest)
                {
                   relatedItems.Add(new ProductEntry() { ProductID = (uint)tempData.Id, CoPurchaseProductID =(uint)o.Id }); 
                }

                var traindata = mlContext.Data.LoadFromEnumerable(relatedItems);
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;

                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                model = est.Fit(traindata);
            }

            var predictionResult = new List<Tuple<Obavijest, float>>();
            foreach (var item in tempdataObavijest)
            {

                var predictionengine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionengine.Predict(
                                         new ProductEntry()
                                         {
                                             ProductID = (uint)id,
                                             CoPurchaseProductID = (uint)item.Id
                                         });
                predictionResult.Add(new Tuple<Obavijest, float>(item, prediction.Score));
            }
            var finalResult = predictionResult.OrderBy(x => x.Item2).Select(x => x.Item1).ToList();
            return finalResult;
        }
    }
}
