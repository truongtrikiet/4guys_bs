using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4guys_bs.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (user.usn == "admin" && user.pwd == "2003")
            {
                return RedirectToAction("Admin", "Home");
            }
            else
            {
                if (user.mail == "4guys@gmail.com" && user.pwd == "2k3")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid username, password, or email.";
                    return View();
                }
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Register(Models.User user)
        {
            List<Models.User> customers = new List<Models.User>(); 
            if (customers.Any(c => c.mail == user.mail))
            {
                ViewBag.ErrorMessage = "The mail is already registed! Please try another mail.";
                return View("Register");
            }

            //customers.Add(new Models.User { mail = user.mail, pwd = user.pwd });
            return RedirectToAction("Login");
        }
    }
}

