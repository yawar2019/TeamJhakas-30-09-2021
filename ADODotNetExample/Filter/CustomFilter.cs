﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADODotNetExample.Filter
{

    public class CustomFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
          
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.player = "Kohli";
        }
    }
}