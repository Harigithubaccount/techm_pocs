using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.Api.Support
{
    public class SlugifyParameterTransformer : IOutboundParameterTransformer
    {
        public string TransformOutbound(object value)
        {
            if (value == null) { return null; }

            return Slugify(value.ToString());
        }
        public static string Slugify(string value) => Regex.Replace(value,
                                 "([a-z])([A-Z])",
                                 "$1-$2",
                                 RegexOptions.CultureInvariant,
                                 TimeSpan.FromMilliseconds(100)).ToLowerInvariant();
    }
}
