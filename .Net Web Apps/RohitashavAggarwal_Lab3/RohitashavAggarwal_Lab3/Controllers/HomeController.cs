using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RohitashavAggarwal_Lab3.Controllers
{
    public class HomeController : Controller
    {
        HalloweenEntities db = new HalloweenEntities();
        public ActionResult Products()
        {
            var products = db.Products.ToList();

            return View(products);
        }

        public ActionResult Details(string id)
        {
            return View(db.Products.Find(id));
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
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