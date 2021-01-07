using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.Specification.DataAccess
{
    public interface IUnitOfWork
    {
        ICityCodeRepository CityCodeRepository { get; }

        ICityRepository CityRepository { get; }

        ICountyRepository CountyRepository { get; }

        IMasterPremiseRepository MasterPremiseRepository { get; }

        IStreetTypeRepository StreetTypeRepository { get; }

        //IMasterServicePointRepository MasterServicePointRepository { get; }

        void Save();
    }
}
