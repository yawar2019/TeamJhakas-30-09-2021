using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TeamJhakas_30_09_2021.CustomRouthandler;
using TeamJhakas_30_09_2021.UserDefinedConstraint;

namespace TeamJhakas_30_09_2021
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.Add(new Route("test", new UserRouteHandler()));

            routes.MapRoute(
               name: "Default1",
               url: "Employee/EmployeeId/{id}",
               defaults: new { controller = "Employee", action = "EmployeName", id = UrlParameter.Optional },
               constraints: new {id=@"\d+"}
           );

            routes.MapRoute(
               name: "Default2",
               url: "New/EmployeeInfo/{EmailId}",
               defaults: new { controller = "Employee", action = "EmailChecker", id = UrlParameter.Optional },
               constraints: new { EmailId = new EmailConstraint() }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "EmployeName", id = UrlParameter.Optional }
            );
        }
    }
}
