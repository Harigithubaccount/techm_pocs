using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core
{
    public abstract class BusinessServiceBaseReadonlyDBEntity<TDBEntity, TId> : BusinessServiceBase, IEntityBusinessServiceBaseForReadonlyDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        protected IRepositoryBaseForReadonlyDBEntity<TDBEntity, TId> Repository { get; }
        public BusinessServiceBaseReadonlyDBEntity(IRepositoryBaseForReadonlyDBEntity<TDBEntity, TId> repository)
        {
            Repository = repository;
        }
        public IQueryable<TDBEntity> GetQueryable() => Repository.GetQueryable();
        public TDBEntity GetById(TId id) => Repository.GetById(id);
    }
}
