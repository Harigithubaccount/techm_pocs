using Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService
{
    public class MasterPremiseBusinessService : BusinessServiceBaseForMutableDBEntity<MasterPremise, int>, IMasterPremiseBusinessService
    {
        public MasterPremiseBusinessService(IMasterPremiseRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
