using Jea.MasterPremiseApp.PremiseService.Api.Controllers.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.Api.Controllers.V1
{
    //[ApiVersion("1.0")]
    public class StreetTypeController : AppControllerBaseForMutableDBEntity<StreetType, string>
    {
        public StreetTypeController(IStreetTypeBusinessService businessService):base(businessService)
        { }
    }
}
