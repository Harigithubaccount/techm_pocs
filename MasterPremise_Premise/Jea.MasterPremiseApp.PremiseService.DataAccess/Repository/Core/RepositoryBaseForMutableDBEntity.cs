using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core
{
    public abstract class RepositoryBaseForMutableDBEntity<TDBEntity, TId> : RepositoryBaseForReadonlyDBEntity<TDBEntity, TId>, IRepositoryBaseForMutableDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        public RepositoryBaseForMutableDBEntity(DbSet<TDBEntity> dbSet) : base(dbSet)
        { }

        public virtual TDBEntity Add(TDBEntity entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual IEnumerable<TDBEntity> AddMultiple(IEnumerable<TDBEntity> entities)
        {
            //foreach (var entity in entities)
            //    Add(entity);
            DbSet.AddRange(entities);
            return entities;
        }

        public virtual TDBEntity SoftDelete(TDBEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TDBEntity> SoftDeleteMultiple(IEnumerable<TDBEntity> entities)
        {
            throw new NotImplementedException();
        }

        public virtual TDBEntity Update(TDBEntity entity)
        {
            DbSet.Update(entity);
            return entity;
        }

        public virtual IEnumerable<TDBEntity> UpdateMultiple(IEnumerable<TDBEntity> entities)
        {
            DbSet.UpdateRange(entities);
            return entities;
        }
    }
}
