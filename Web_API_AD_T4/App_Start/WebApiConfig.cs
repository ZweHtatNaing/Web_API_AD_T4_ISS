using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using Web_API_AD_T4.Controllers;

namespace Web_API_AD_T4
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
          
            config.MapHttpAttributeRoutes(new CustomDirectRouteProvider());
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
        public class CustomDirectRouteProvider : DefaultDirectRouteProvider
        {
            protected override IReadOnlyList<IDirectRouteFactory>
            GetActionRouteFactories(HttpActionDescriptor actionDescriptor)
            {
                return actionDescriptor.GetCustomAttributes<IDirectRouteFactory>
                (inherit: true);
            }
        }
    }
}
