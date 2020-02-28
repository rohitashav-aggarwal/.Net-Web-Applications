using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RohitashavAggarwal_Workshop5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Beat Me: Challenge Platform";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details: ";

            return View();
        }
    }
}