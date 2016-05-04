using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoggingWebApplication.Controllers
{
    using System.Diagnostics;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new ApplicationException("An error occurred here.");
            return View();
        }

        public ActionResult About()
        {
            Trace.TraceInformation("Let's talk about me");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}