using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core
{
    public interface IRepositoryBaseForReadonlyDBEntity<TDBEntity, TId> : IRepositoryBase where TDBEntity : class where TId : IConvertible
    {
        public IQueryable<TDBEntity> GetQueryable();
        public TDBEntity GetById(TId id);
    }
}
