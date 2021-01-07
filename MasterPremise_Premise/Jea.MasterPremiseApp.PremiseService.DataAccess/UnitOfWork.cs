using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public JeaPocContext JeaPocContext { get; }

        public IMasterPremiseRepository MasterPremiseRepository { get; }

        public IStreetTypeRepository StreetTypeRepository { get; }

        public IMasterServicePointRepository MasterServicePointRepository { get; }

        public ICityCodeRepository CityCodeRepository { get; }

        public ICityRepository CityRepository { get; }

        public ICountyRepository CountyRepository { get; }

        public UnitOfWork(JeaPocContext jeaPocContext, IMasterPremiseRepository masterPremiseRepository, IStreetTypeRepository streetTypeRepository, IMasterServicePointRepository masterServicePointRepository, ICityCodeRepository cityCodeRepository, ICityRepository cityRepository, ICountyRepository countyRepository)
        {
            JeaPocContext = jeaPocContext;
            MasterPremiseRepository = masterPremiseRepository;
            StreetTypeRepository = streetTypeRepository;
            MasterServicePointRepository = masterServicePointRepository;
            CityCodeRepository = cityCodeRepository;
            CityRepository = cityRepository;
            CountyRepository = countyRepository;
        }

        public void Save() => JeaPocContext.SaveChanges();        
    }
}
