using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace ProductMaintenanceMVC.Controllers
{
    public class ProductsController : Controller
    {
        ProductsEntities db = new ProductsEntities();
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        // GET: Products/Details/a123
        public ActionResult Details(string id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            else
            {
                try
                {
                    Product p = db.Products.Find(id);
                    return View(p);
                }
                catch
                {
                    return View();
                }
            }
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product p)
        {
            try
            {
                //Product p = new Product();
                //p.Code = c["Code"];
                //p.Description = c["Description"];
                //p.Price = Convert.ToDecimal(c["Price"]);
                //p.Quantity = Convert.ToInt32(c["Quantity"]);

                db.Products.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/a123
        public ActionResult Edit(string id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            else
            {
                try
                {
                    Product p = db.Products.Find(id);
                    return View(p);
                }
                catch
                {
                    return View();
                }
            }
        }

        // POST: Products/Edit/a123
        [HttpPost]
        public ActionResult Edit(string id, Product p)
        {
            try
            {
                p = db.Products.Find(id);
                if (p == null)
                    return HttpNotFound();
                else
                {
                    db.Entry(p).State = EntityState.Modified; // mark for update
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View(p);
            }
        }

        // GET: Products/Delete/a123
        public ActionResult Delete(string id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            else
            {
                try
                {
                    Product p = db.Products.Find(id);
                    return View(p);
                }
                catch
                {
                    return View();
                }
            }
        }

        // POST: Products/Delete/a123
        [HttpPost]
        public ActionResult Delete(string id, Product p)
        {
            try
            {
                p = db.Products.Find(id);
                if (p == null)
                    return HttpNotFound();
                else
                {
                    db.Entry(p).State = EntityState.Deleted; // mark for delete
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }             
            }
            catch
            {
                return View();
            }
        }
    }
}
