using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleAspMVC.Filters
{
   public class LogAttribute: ActionFilterAttribute
    {
       public override void OnActionExecuting(ActionExecutingContext filterContext)
       {
           base.OnActionExecuting(filterContext);
       }
    }
}