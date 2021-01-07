using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core
{
    public interface IEntityBusinessServiceBaseForReadonlyDBEntity<TDBEntity, TId> : IEntityBusinessServiceBase where TDBEntity : class where TId: IConvertible
    {
        public IQueryable<TDBEntity> GetQueryable();
        public TDBEntity GetById(TId id);
    }
}
