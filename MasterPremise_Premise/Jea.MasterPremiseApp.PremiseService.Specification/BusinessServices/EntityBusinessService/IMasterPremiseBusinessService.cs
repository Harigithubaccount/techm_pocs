using System;
using System.Collections.Generic;
using System.Text;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Dto;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;

namespace Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService
{
    public interface IMasterPremiseBusinessService : IEntityBusinessServiceBaseForMutableDBEntity<MasterPremise, int>
    { }
}
