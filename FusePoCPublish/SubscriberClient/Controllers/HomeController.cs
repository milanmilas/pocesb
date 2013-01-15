using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubscriberClient.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> messages = new List<string>(); 

        public static void AddMessage(string message)
        {
            messages.Add(message);
        }

        [HttpGet]
        public string getMessage()
        {
            var message = messages.FirstOrDefault();
            if (message != null)
            {
                messages.Remove(message);
            }
            else
            {
                message = "-";
            }

            return message;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "this will be content";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
