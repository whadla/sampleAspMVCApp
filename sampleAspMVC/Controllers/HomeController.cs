using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleAspMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["Action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}::{1}::{2}", controller, action, id);
            ViewBag.message = message;
            return View();
        }

        public ActionResult About()
        {
            var model = new sampleAspMVC.Models.AboutModel();
            model.Name = "IR";
            model.Location = "Kiev. Ukraine";
            

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}