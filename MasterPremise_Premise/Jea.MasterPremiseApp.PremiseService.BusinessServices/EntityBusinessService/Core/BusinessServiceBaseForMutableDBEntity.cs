using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core
{
    public abstract class BusinessServiceBaseForMutableDBEntity<TDBEntity, TId> : BusinessServiceBaseReadonlyDBEntity<TDBEntity, TId>, IEntityBusinessServiceBaseForMutableDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected new IRepositoryBaseForMutableDBEntity<TDBEntity, TId> Repository { get; }
        public BusinessServiceBaseForMutableDBEntity(IRepositoryBaseForMutableDBEntity<TDBEntity, TId> repository, IUnitOfWork unitOfWork) : base(repository)
        {
            UnitOfWork = unitOfWork;
            Repository = repository;
            var repoInUow = typeof(IUnitOfWork).GetProperty(repository.GetType().Name).GetValue(UnitOfWork);
            if (repository != repoInUow)
                throw new ArgumentException($"The 'Repository' ({repository.GetType().Name}) could not be found in the UnitOfWork ");
        }

        public TDBEntity Add(TDBEntity entity)
        {
            entity = Repository.Add(entity);
            UnitOfWork.Save();
            return entity;
        }

        public IEnumerable<TDBEntity> AddMultiple(IEnumerable<TDBEntity> entities)
        {
            entities = Repository.AddMultiple(entities);
            UnitOfWork.Save();
            return entities;
        }

        public TDBEntity SoftDelete(TDBEntity entity)
        {
            entity = Repository.SoftDelete(entity);
            UnitOfWork.Save();
            return entity;
        }

        public IEnumerable<TDBEntity> SoftDeleteMultiple(IEnumerable<TDBEntity> entities)
        {
            entities = Repository.SoftDeleteMultiple(entities);
            UnitOfWork.Save();
            return entities;
        }

        public TDBEntity Update(TDBEntity entity)
        {
            entity = Repository.Update(entity);
            UnitOfWork.Save();
            return entity;
        }

        public IEnumerable<TDBEntity> UpdateMultiple(IEnumerable<TDBEntity> entities)
        {
            entities = Repository.UpdateMultiple(entities);
            UnitOfWork.Save();
            return entities;
        }
    }
}
