﻿using Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityBusinessService
{
    public class CountyBusinessService : BusinessServiceBaseForMutableDBEntity<County, int>, ICountyBusinessService
    {
        public CountyBusinessService(ICountyRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
