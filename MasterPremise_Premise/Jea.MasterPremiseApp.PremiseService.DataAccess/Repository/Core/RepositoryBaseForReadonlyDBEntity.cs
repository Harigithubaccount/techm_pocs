using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core
{
    public abstract class RepositoryBaseForReadonlyDBEntity<TDBEntity, TId> : RepositoryBase, IRepositoryBaseForReadonlyDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        protected DbSet<TDBEntity> DbSet { get; }
        public RepositoryBaseForReadonlyDBEntity(DbSet<TDBEntity> dbSet)
        {
            DbSet = dbSet;
        }

        public IQueryable<TDBEntity> GetQueryable() => DbSet;
        public virtual TDBEntity GetById(TId id) => DbSet.Find(id);
    }
}
