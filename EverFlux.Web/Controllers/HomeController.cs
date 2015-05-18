using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EverFlux.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Comingsoon");
      
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("Comingsoon");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Comingsoon");
        }


        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Comingsoon");
        }

        public ActionResult Comingsoon()
        {
            return View();
        }

   
    }
}