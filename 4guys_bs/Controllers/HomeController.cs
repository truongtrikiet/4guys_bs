using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _4guys_bs.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Server;
using Microsoft.AspNetCore.Components.Server;
using System.Formats.Asn1;
using System.Globalization;

namespace _4guys_bs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Admin()
    {
        return View();
    }

    public IActionResult Forms()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult Login()
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
    public IActionResult Register()
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

