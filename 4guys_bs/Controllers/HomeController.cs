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

    public IActionResult Login()
    {
        return View();
    }
    //read the file .csv
    

    // end read csv


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

