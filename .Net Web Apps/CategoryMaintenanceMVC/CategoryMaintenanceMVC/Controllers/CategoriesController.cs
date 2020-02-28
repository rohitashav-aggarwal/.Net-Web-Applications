using CategoryMaintenanceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CategoryMaintenanceMVC.Controllers
{
    public class CategoriesController : Controller
    {
        List<Category> categories;

        // GET: Categories
        public ActionResult Index()
        {
            categories = CategoryDB.GetCategories(); // all categories
            return View(categories);
        }

        // GET: Categories/Details/fx
        public ActionResult Details(string id)
        {
            // need to create the view
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                CategoryDB.InsertCategory(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Edit/fx
        public ActionResult Edit(string id)
        {
            Category currentCat = CategoryDB.GetCategoryByID(id);
            return View(currentCat);
        }

        // POST: Categories/Edit/fx
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Category newCategory)
        {
            try
            {
                Category currentCategory = CategoryDB.GetCategoryByID(id);
                //Thread.Sleep(10000);
                int count = CategoryDB.UpdateCategory(currentCategory, newCategory);
                if (count == 0)// no update due to concurrency issue
                    TempData["errorMessage"] = "Update aborted. " +
                        "Another user changed or deleted this row";
                else
                    TempData["errorMessage"] = "";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/fx
        public ActionResult Delete(string id)
        {
            Category currentCat = CategoryDB.GetCategoryByID(id);
            return View(currentCat);
        }

        // POST: Categories/Delete/fx
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                Category cat = CategoryDB.GetCategoryByID(id);
                int count = CategoryDB.DeleteCategory(cat);
                if (count == 0)// no update due to concurrency issue
                    TempData["errorMessage"] = "Delete aborted. " +
                        "Another user changed or deleted this row";
                else
                    TempData["errorMessage"] = "";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
