using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace TeamJhakas_30_09_2021.CustomRouthandler
{
    public class UserRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
             return new CustomHttpHandler();
        }
        public class CustomHttpHandler : IHttpHandler
        {
            public bool IsReusable
            {
                get;set;
            }

            public void ProcessRequest(HttpContext context)
            {
                context.Response.Redirect("http://wwww.google.com");
            }
        }
    }
}