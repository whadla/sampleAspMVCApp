using sampleAspMVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleAspMVC.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [Log]
        public ActionResult Search(string name = "italian")
        {
            throw new Exception("Ups");
            var message = Server.HtmlEncode(name);
            return Content(message);
                
        }
    }
}