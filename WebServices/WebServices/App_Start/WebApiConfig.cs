using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace WebServices
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Set JSON over XML for Chrome
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new RequestHeaderMapping("Accept", "text/html", StringComparison.InvariantCultureIgnoreCase, true, "application/json"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
