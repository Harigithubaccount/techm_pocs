using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository;
using Jea.MasterPremiseApp.PremiseService.Specification.DataAccess.Repository.Core;
using Jea.MasterPremiseApp.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.DataAccess
{
    public static class InitializerForDataAccess
    {
        public static void ConfigureServicesForDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JeaPocContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("JeaDB"))
            );
            //services.AddScoped<IMasterPremiseRepository, MasterPremiseRepository>();
            //services.AddScoped<IStreetTypeRepository, StreetTypeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var repositories = ReflectionUtilities.GetTypesForRegistration<RepositoryBase, IRepositoryBase>();
            foreach(var repo in repositories)
                services.AddScoped(repo.serviceType, repo.implementationType);
        }
    }
}
