using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository
{
    public class StreetTypeRepository : RepositoryBaseForMutableDBEntity<StreetType,string>, IStreetTypeRepository
    {
        private static readonly List<StreetType> _streetTypes = new List<StreetType>()
        {
            //new StreetType {StreetTypeId = "ST", FullName = "Street"},
            //new StreetType {StreetTypeId = "LP", FullName = "Loop"},
            //new StreetType {StreetTypeId = "RD", FullName = "Road"},
            //new StreetType {StreetTypeId = "WY", FullName = "Way" },
            //new StreetType {StreetTypeId = "BV", FullName = "Boulevard"},
            //new StreetType {StreetTypeId = "AV", FullName = "Avenue"},
            //new StreetType {StreetTypeId = "TL", FullName = "Trail"},
            //new StreetType {StreetTypeId = "TR", FullName = "Trace"},
            //new StreetType {StreetTypeId = "AL", FullName = "Alley"},
            //new StreetType {StreetTypeId = "XY", FullName = "Expressway"},
            //new StreetType {StreetTypeId = "TE", FullName = "Terrace"},
            //new StreetType {StreetTypeId = "EX", FullName = "Extension"},
            //new StreetType {StreetTypeId = "CS", FullName = "Crescent"},
            //new StreetType {StreetTypeId = "PT", FullName = "Point"},
            //new StreetType {StreetTypeId = "SQ", FullName = "Square"},
            //new StreetType {StreetTypeId = "AN", FullName = "Annex"},
            //new StreetType {StreetTypeId = "DR", FullName = "Drive"},
            //new StreetType {StreetTypeId = "HY", FullName = "Highway"},
            //new StreetType {StreetTypeId = "CV", FullName = "Cove"},
            //new StreetType {StreetTypeId = "PZ", FullName = "Plaza"},
            //new StreetType {StreetTypeId = "LA", FullName = "Lane"},
            //new StreetType {StreetTypeId = "CT", FullName = "Court"},
            //new StreetType {StreetTypeId = "PL", FullName = "Place"},
            //new StreetType {StreetTypeId = "PY", FullName = "Parkway"},
            //new StreetType {StreetTypeId = "CR", FullName = "Circle"},
            //new StreetType {StreetTypeId = "KY", FullName = "Key"},
            //new StreetType {StreetTypeId = "RW", FullName = "Row"},
            //new StreetType {StreetTypeId = "ML", FullName = "Mall"},
        };

        public StreetTypeRepository(JeaPocContext dbContext, ILogger<StreetType> logger) : base(dbContext.StreetTypes)
        { }

        //public StreetTypeRepository()
        //{
        //}

        //public StreetType GetById(string id)
        //{
        //    //commented for debugging   return _streetTypes.Single(x => x.Abbreviation == id);
        //    throw new NotImplementedException();
        //}

        //public IQueryable<StreetType> GetQueryable() => _streetTypes.AsQueryable();
    }
}
