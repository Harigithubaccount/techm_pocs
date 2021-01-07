using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository
{
    public class MasterPremiseRepository : RepositoryBaseForMutableDBEntity<MasterPremise, int>, IMasterPremiseRepository
    {
        private static readonly List<Premise> _premises = new List<Premise>()
        {
            new Premise {PremiseId = 1, CityCode = "00", StreetCode="1234", HouseNo="101"  },
            new Premise {PremiseId = 2, CityCode = "00", StreetCode="1234", HouseNo="102"  },
            new Premise {PremiseId = 3, CityCode = "00", StreetCode="1234", HouseNo="103"  },
            new Premise {PremiseId = 4, CityCode = "06", StreetCode="1235", HouseNo="104"  },
            new Premise {PremiseId = 5, CityCode = "06", StreetCode="1235", HouseNo="105"  },
            new Premise {PremiseId = 6, CityCode = "06", StreetCode="1235", HouseNo="106"  },
        };

        //public PremiseRepository()
        //{
        //}

        public MasterPremiseRepository(JeaPocContext dbContext, ILogger<MasterPremiseRepository> logger) : base(dbContext.MasterPremises)
        {
            logger.LogDebug("inside Premise Repository Constructor");
        }

        //public Premise Add(Premise entity)
        //{
        //    entity.PremiseId = _premises.Count + 1;
        //    _premises.Add(entity);
        //    return entity;
        //}

        //public IEnumerable<Premise> AddMultiple(IEnumerable<Premise> entities)
        //{
        //    List<Premise> addedEntities = new List<Premise>();
        //    foreach (var entity in entities)
        //        addedEntities.Add(Add(entity));
        //    return addedEntities;
        //}

        //public IQueryable<Premise> GetQueryable()
        //{
        //    return _premises.AsQueryable();
        //}

        //public Premise SoftDelete(Premise entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Premise> SoftDeleteMultiple(IEnumerable<Premise> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public Premise Update(Premise entity)
        //{
        //    var requiredPremise = _premises.Single(x => x.PremiseId == entity.PremiseId);
        //    _premises.Remove(requiredPremise);
        //    _premises.Add(entity);
        //    return entity;
        //}

        //public IEnumerable<Premise> UpdateMultiple(IEnumerable<Premise> entities)
        //{
        //    List<Premise> updatedEntities = new List<Premise>();
        //    foreach (var entity in entities)
        //        updatedEntities.Add(Update(entity));
        //    return updatedEntities;
        //}
    }
}
