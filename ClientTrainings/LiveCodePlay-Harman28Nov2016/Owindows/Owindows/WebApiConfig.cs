using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Owindows
{
    public class WebApiConfig
    {

        // route configurations 

        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllInsurers",
                routeTemplate: "insurances",
                defaults: new { controller = "Insurance", action = "Get" }
                );
        }
    }
}