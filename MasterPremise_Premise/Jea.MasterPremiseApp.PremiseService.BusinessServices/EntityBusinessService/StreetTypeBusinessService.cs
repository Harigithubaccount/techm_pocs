using Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices
{
    public class StreetTypeBusinessService : BusinessServiceBaseForMutableDBEntity<StreetType, string>, IStreetTypeBusinessService
    {
        public StreetTypeBusinessService(IStreetTypeRepository repository, IUnitOfWork unitOfWork) :base(repository, unitOfWork)
        { }
    }
}
