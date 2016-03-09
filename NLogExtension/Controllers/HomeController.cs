using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using NLogExtension.Extensions;

namespace NLogExtension.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            Logger.ActionInit("HomeController Index");
            Logger.Debug("Sample debug message");

            return View();
        }

        public ActionResult About()
        {
            Logger.ActionInit("HomeController About");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Logger.ActionInit("HomeController Contact");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}