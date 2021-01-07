using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Extensions;
using Jea.MasterPremiseApp.PremiseService.BusinessServices;
using Jea.MasterPremiseApp.PremiseService.DataAccess;
using Jea.MasterPremiseApp.PremiseService.Integration;
using Jea.MasterPremiseApp.PremiseService.Chassis;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Serilog;
using Serilog.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.Extensions.PlatformAbstractions;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Jea.MasterPremiseApp.PremiseService.Api.Support;

namespace Jea.MasterPremiseApp.PremiseService.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<ILoggerProvider>(sp =>
            //{
            //    var functionDependencyContext = Microsoft.Extensions.DependencyModel.DependencyContext.Load(typeof(Startup).Assembly);

            //    var hostConfig = sp.GetRequiredService<IConfiguration>();
            //    var logger = new LoggerConfiguration()
            //        .ReadFrom.Configuration(hostConfig, sectionName: "Serilog", dependencyContext: functionDependencyContext)
            //        .CreateLogger();

            //    return new SerilogLoggerProvider(logger, dispose: true);
            //});
            services.AddCors(options => 
                options.AddDefaultPolicy(builder => 
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            // Add API Controllers
            services.AddControllers();
            // API versioning support
            //api-ver services.AddApiVersioning(options => { options.ReportApiVersions = true; options.ApiVersionReader = new JeaUriSegmentApiVersionReader(); });
            ////api-ver services.AddVersionedApiExplorer(
            //                options =>
            //                {
            //                    // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
            //                    // note: the specified format code will format the version as "'v'major[.minor][-status]"
            //                    options.GroupNameFormat = "'v'VVV";

            //                    // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
            //                    // can also be used to control the format of the API version in route templates
            //                    // - debug options.SubstituteApiVersionInUrl = true;
            //                });
            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            // To enable HTTP Patch
            services.AddControllersWithViews(options =>
            {
                //options.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            }).AddNewtonsoftJson();
            // to add OData support
            services.AddOData();
            // service extensions from the solution component libraries
            services.ConfigureServicesForChassis();
            services.ConfigureServicesForDataAccess(Configuration);
            services.ConfigureServicesForIntegration();
            services.ConfigureServicesForBusinessServices();

            // for Swagger support
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Jea.MasterPremiseApp.PremiseService.Api", Version = "v1" });
                // add a custom operation filter which sets default values
                //options.OperationFilter<SwaggerDefaultValues>();

                //// integrate xml comments
                //options.IncludeXmlComments(XmlCommentsFilePath);
            });
            // for Swagger Support
            services.AddMvcCore(options =>
            {
                options.Conventions.Add(new Support.NamespaceRoutingConvention(string.Join(".", typeof(Startup).Namespace, "Controllers")));
                options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
                foreach (var outputFormatter in options.OutputFormatters.OfType<OutputFormatter>().Where(x => x.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }

                foreach (var inputFormatter in options.InputFormatters.OfType<InputFormatter>().Where(x => x.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSerilogRequestLogging();

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Jea.MasterPremiseApp.PremiseService.Api v1"));

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.Select().Filter().OrderBy().MaxTop(300/*TODO move this to configuration?*/).Count();
                endpoints.EnableDependencyInjection();
            });
        }

        static string XmlCommentsFilePath
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }

        //private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
        //{
        //    var builder = new ServiceCollection()
        //        .AddLogging()
        //        .AddMvc()
        //        .AddNewtonsoftJson()
        //        .Services.BuildServiceProvider();

        //    return builder
        //        .GetRequiredService<IOptions<MvcOptions>>()
        //        .Value
        //        .InputFormatters
        //        .OfType<NewtonsoftJsonPatchInputFormatter>()
        //        .First();
        //}
    }
}
