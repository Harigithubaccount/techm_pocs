using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Jea.MasterPremiseApp.PremiseService.Api
{
    public class JeaUriSegmentApiVersionReader : IApiVersionReader
    {
        public void AddParameters(IApiVersionParameterDescriptionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            //foreach (var name in ParameterNames)
            //{
            //    context.AddParameter(name, DbLoggerCategory.Query);
            //}
        }

        public string Read(HttpRequest request)
        {
            return "1.0";
        }
    }
}
