using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace YouTube
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //     name: "videpApi",
            //     routeTemplate: "api/Video2/{id}",
            //     defaults: new { id = RouteParameter.Optional }
            // );
        }
    }
}
