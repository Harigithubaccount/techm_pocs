using Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService;
using Jea.MasterPremiseApp.PremiseService.BusinessServices.EntityService.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService;
using Jea.MasterPremiseApp.PremiseService.Specification.BusinessServices.EntityBusinessService.Core;
using Jea.MasterPremiseApp.Utilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.BusinessServices
{
    public static class InitializerForBusinessServices
    {
        public static void ConfigureServicesForBusinessServices(this IServiceCollection services)
        {
            //services.AddScoped<IMasterPremiseBusinessService, MasterPremiseBusinessService>();
            //services.AddScoped<IStreetTypeBusinessService, StreetTypeBusinessService>();

            var repositories = ReflectionUtilities.GetTypesForRegistration<BusinessServiceBase, IEntityBusinessServiceBase>();
            foreach (var repo in repositories)
                services.AddScoped(repo.serviceType, repo.implementationType);
        }
    }
}
