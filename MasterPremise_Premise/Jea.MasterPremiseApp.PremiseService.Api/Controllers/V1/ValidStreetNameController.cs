using Jea.MasterPremiseApp.PremiseService.Api.Controllers.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.Api.Controllers.V1
{
    public class ValidStreetNameController : AppControllerBaseForReadonlyDBEntity<ValidStreetName, int>
    {
        public ValidStreetNameController(IValidStreetNameBusinessService businessService) : base(businessService)
        { }
    }
}
