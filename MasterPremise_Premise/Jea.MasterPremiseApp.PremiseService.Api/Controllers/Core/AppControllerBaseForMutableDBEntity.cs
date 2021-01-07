using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Jea.MasterPremiseApp.PremiseService.Api.Controllers.Core
{
    [Produces(MediaTypeNames.Application.Json)]
    public class AppControllerBaseForMutableDBEntity<TDBEntity, TId> : AppControllerBaseForReadonlyDBEntity<TDBEntity, TId> where TDBEntity : class where TId : IConvertible
    {
        protected new IEntityBusinessServiceBaseForMutableDBEntity<TDBEntity, TId> BusinessService { get; }
        public AppControllerBaseForMutableDBEntity(IEntityBusinessServiceBaseForMutableDBEntity<TDBEntity, TId> businessService) : base(businessService)
        {
            BusinessService = businessService;
        }

        //[HttpPost]
        //public TDBEntity Add(TDBEntity entity) => BusinessService.Add(entity);

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public IEnumerable<TDBEntity> AddMultiple([FromBody] IEnumerable<TDBEntity> entities) => BusinessService.AddMultiple(entities);

        //[HttpPut]
        //public TDBEntity Update(TDBEntity entity) => BusinessService.Update(entity);

        [HttpPut]
        [Consumes(MediaTypeNames.Application.Json)]
        public IEnumerable<TDBEntity> UpdateMultiple([FromBody] IEnumerable<TDBEntity> entities) => BusinessService.UpdateMultiple(entities);

        //[HttpDelete]
        //public TDBEntity SoftDelete(TDBEntity entity) => SoftDelete(entity);

        //[HttpDelete]
        //public IEnumerable<TDBEntity> SoftDeleteMultiple(IEnumerable<TDBEntity> entities) => SoftDeleteMultiple(entities);

        [HttpPatch("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        //[HttpPatch]
        public void Patch(TId id, [FromBody] JsonPatchDocument<TDBEntity> entityPath)
        {
            TDBEntity entity = BusinessService.GetById(id);
            entityPath.ApplyTo(entity);
            BusinessService.Update(entity);
        }

        [HttpPatch("id-list/{ids}")]   //[[{ids}]]
        [Consumes("application/json")]
        public void Patch(/*[FromQuery]*/string ids, [FromBody] JsonPatchDocument<TDBEntity> entityPath)
        {
            var idList = JsonConvert.DeserializeObject<TId[]>($"[{ids}]");
            // TODO optimize by reading all required entities in one-go
            foreach(var id in idList)
            {
                var entity = BusinessService.GetById(id);
                entityPath.ApplyTo(entity);
                BusinessService.Update(entity);
            }
        }
    }
}
