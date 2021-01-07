using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core
{
    public interface IDtoAdaptorForMutableDBEntity<TDBEntity, TDto, TId> : IDtoAdaptorForReadonlyDBEntity<TDBEntity, TDto, TId> where TDBEntity : class where TDto : class where TId : struct
    {
        public TDto Add(TDto entity);
        public IEnumerable<TDBEntity> AddMultiple(IEnumerable<TDto> entityDtos);
        public TDBEntity Update(TDto entityDto);
        public IEnumerable<TDBEntity> UpdateMultiple(IEnumerable<TDto> entityDtos);
        public TDBEntity SoftDelete(TDto entityDto);
        public IEnumerable<TDBEntity> SoftDeleteMultiple(IEnumerable<TDto> entityDtos);
    }
}
