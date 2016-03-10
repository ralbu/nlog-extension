using System.Diagnostics;
using System.Threading;
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

            GetUsers();

            GetActiveItems();

            Logger.Debug("Sample debug message");

            return View();
        }

        private void GetUsers()
        {
            Logger.Debug("Get all users");

            Stopwatch sw = Stopwatch.StartNew();
            Thread.Sleep(700);
            sw.Stop();

            Logger.Performance($"Getting users in: {sw.ElapsedMilliseconds}");
        }

        private void GetActiveItems()
        {
            Logger.Debug("Searching for active items");

            Stopwatch sw = Stopwatch.StartNew();
            Thread.Sleep(300);
            sw.Stop();
            Logger.Performance($"Searching active items in: {sw.ElapsedMilliseconds}");
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