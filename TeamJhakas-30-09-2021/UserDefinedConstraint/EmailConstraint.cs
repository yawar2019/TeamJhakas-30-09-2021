using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace TeamJhakas_30_09_2021.UserDefinedConstraint
{
    public class EmailConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string Email = values["EmailId"].ToString();
            if (Email.Contains("@"))
            {
                return true;
            }
            return false;
        }
    }
}