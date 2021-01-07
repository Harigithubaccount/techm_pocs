using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jea.MasterPremiseApp.PremiseService.Api.Support
{
    public class NamespaceRoutingConvention : Attribute, IControllerModelConvention
    {
        private readonly string _baseNamespace;

        public NamespaceRoutingConvention(string baseNamespace)
        {
            _baseNamespace = baseNamespace;
        }

        public void Apply(ControllerModel controller)
        {
            var hasRouteAttributes = controller.Selectors.Any(selector =>
                                                    selector.AttributeRouteModel != null);
            if (hasRouteAttributes)
            {
                return;
            }

            var namespc = controller.ControllerType.Namespace;
            if (namespc == null)
                return;
            if (!namespc.StartsWith(_baseNamespace))
                return;
            var template = new StringBuilder();
            template.Append(namespc, _baseNamespace.Length + 1,
                            namespc.Length - _baseNamespace.Length - 1);
            template.Replace('.', '/');
            //template.Append("/[controller]/[action]/{id?}");
            template.Append("/[controller]");

            foreach (var selector in controller.Selectors)
            {
                selector.AttributeRouteModel = new AttributeRouteModel()
                {
                    Template = SlugifyParameterTransformer.Slugify(template.ToString())
                };
            }
        }
    }
}
