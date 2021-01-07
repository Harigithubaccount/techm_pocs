using System;
using System.Collections.Generic;
using System.Text;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;

namespace Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository
{
    public interface IMasterPremiseRepository : IRepositoryBaseForMutableDBEntity<MasterPremise, int>
    { }
}
