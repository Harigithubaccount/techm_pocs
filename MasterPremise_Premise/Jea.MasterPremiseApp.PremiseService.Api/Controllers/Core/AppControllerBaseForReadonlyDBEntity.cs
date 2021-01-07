using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using System.Net.Mime;

namespace Jea.MasterPremiseApp.PremiseService.Api.Controllers.Core
{
    [Produces(MediaTypeNames.Application.Json)]
    public class AppControllerBaseForReadonlyDBEntity<TDBEntity, TId> : AppControllerBase where TDBEntity : class where TId : IConvertible
    {
        protected IEntityBusinessServiceBaseForReadonlyDBEntity<TDBEntity, TId> BusinessService { get; }
        public AppControllerBaseForReadonlyDBEntity(IEntityBusinessServiceBaseForReadonlyDBEntity<TDBEntity, TId> businessService)
        {
            BusinessService = businessService;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<TDBEntity> GetEntities() => BusinessService.GetQueryable();

        [HttpGet("{id}")]
        //[HttpGet]
        public TDBEntity GetDBEntity(TId id) => BusinessService.GetById(id);
    }
}
