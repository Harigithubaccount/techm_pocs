using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core
{
    public interface IRepositoryBaseForMutableDBEntity<TDBEntity, TId> : IRepositoryBaseForReadonlyDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        public TDBEntity Add(TDBEntity entity);
        public IEnumerable<TDBEntity> AddMultiple(IEnumerable<TDBEntity> entities);
        public TDBEntity Update(TDBEntity entity);
        public IEnumerable<TDBEntity> UpdateMultiple(IEnumerable<TDBEntity> entities);
        public TDBEntity SoftDelete(TDBEntity entity);
        public IEnumerable<TDBEntity> SoftDeleteMultiple(IEnumerable<TDBEntity> entities);
    }
}
