using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstMVCAppSCAGT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            ////Custom
            //routes.MapRoute(
            //    name: "User",
            //    url: "User/{controller}/{action}/{id}",
            //    defaults: new { controller = "UserNew", action = "Index", id = UrlParameter.Optional }
            //);

            /// Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "EntityFrameworkDemo", action = "Index", id = UrlParameter.Optional }
            );

            //MVC :: localHost/ControllerName/ActionName?id=20&firstname=jigar
        }
    }
}
