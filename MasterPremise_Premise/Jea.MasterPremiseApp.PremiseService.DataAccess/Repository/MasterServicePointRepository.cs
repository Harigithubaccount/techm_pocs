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
    public class MasterServicePointRepository : RepositoryBaseForMutableDBEntity<MasterServicePoint, int>, IMasterServicePointRepository
    {
        public MasterServicePointRepository(JeaPocContext dbContext, ILogger<MasterServicePoint> logger) : base(dbContext.MasterServicePoints)
        { }
    }
}
