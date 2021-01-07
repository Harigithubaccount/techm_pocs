using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;

namespace Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository
{
    public interface ICountyRepository : IRepositoryBaseForMutableDBEntity<County, int>
    { }
}
