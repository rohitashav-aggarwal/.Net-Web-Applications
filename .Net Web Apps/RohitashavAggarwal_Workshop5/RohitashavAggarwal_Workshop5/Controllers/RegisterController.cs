using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RohitashavAggarwal_Workshop5.Models;

namespace RohitashavAggarwal_Workshop5.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult RegisterNew()
        {
            Registration reg = new Registration();
            TryUpdateModel(reg);
            //encrpt
            if (ModelState.IsValid)
            {
                reg.Password = Encryption.Encrypt(reg.Password);
                RegistrationDB.RegisterCustomer(reg);
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult LoginUser(Registration reg)
        {
            try
            {
                string password = LoginDB.Login(reg.UserName);

                if (Encryption.Decrypt(reg.Password.ToString(), password))
                {
                    Session["UserName"] = reg.UserName;
                    Session["Details"]= reg;
                    return RedirectToAction("Welcome", "Register");
                }
                else
                {
                    ViewBag.Message = "The Username or password is incorrect";
                    return View();
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult Welcome()
        {
            ViewBag.Message = "Welcome" + " " + Session["UserName"];
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            ViewBag.Message = "The Username or Password is Incorrect.";
            return View();
        }

        [HttpGet]
        public ActionResult CustomerAccount()
        {
            Registration registration = new Registration();
            registration = LoginDB.GetCustomer(Session["UserName"].ToString());
            return View(registration);
        }

        [HttpGet]
        public ActionResult CustomerAccountEdit(Registration reg)
        {
            Registration registration = new Registration();
            registration = LoginDB.GetCustomer(Session["UserName"].ToString());
            return View(registration);
        }

        [HttpPost]
        public ActionResult CustomerAccountEdit()
        {
            Registration reg = new Registration();
            TryUpdateModel(reg);
            //encrpt

            if (ModelState.IsValid)
            {
                reg.Password = Encryption.Encrypt(reg.Password);
                CustomerAccountDB.UpdateAccount(reg, Session["UserName"].ToString());
                return RedirectToAction("CustomerAccount");
            }
            
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session["UserName"] = null;
            return RedirectToAction("login", "Register");
        }
    }
}