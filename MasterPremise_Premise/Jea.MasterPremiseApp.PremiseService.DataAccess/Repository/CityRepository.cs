﻿using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository
{
    public class CityRepository : RepositoryBaseForMutableDBEntity<City, int>, ICityRepository
    {
        public CityRepository(JeaPocContext dbContext, ILogger<City> logger) : base(dbContext.Cities)
        { }
    }
}
