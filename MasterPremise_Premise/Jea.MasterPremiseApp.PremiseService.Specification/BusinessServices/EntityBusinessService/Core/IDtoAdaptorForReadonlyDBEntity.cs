using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core
{
    public interface IDtoAdaptorForReadonlyDBEntity<TDBEntity, TDto, TId> where TDBEntity : class where TDto : class where TId : struct
    {
        public IQueryable<TDto> GetQueryable();
    }
}
