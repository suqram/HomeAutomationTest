using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HomeAutomationTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rest-path, only get implemented
            routes.MapRoute(
                name: "Home",
                url: "home/{id}/data",
                defaults: new { controller = "Home", action = "HouseData" }
            );
        }
    }
}
