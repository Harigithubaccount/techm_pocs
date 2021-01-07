using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess.Repository
{
    public class CountyRepository : RepositoryBaseForMutableDBEntity<County, int>, ICountyRepository
    {
        public CountyRepository(JeaPocContext dbContext, ILogger<County> logger) : base(dbContext.Counties)
        { }
    }
}
