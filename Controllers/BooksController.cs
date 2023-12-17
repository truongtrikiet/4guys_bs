using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using _4guys_bs.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace _4guys_bs.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult ReadBookData() {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "bookdata.json");
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            return View(books);
        }
    }
}

