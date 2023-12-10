using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using _4guys_bs.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4guys_bs.Controllers
{
    public class BooksController : Controller
    {
        //public IActionResult Admin()
        //{
        //    var books = LoadBooksFromCsv("Users/trikiettruong2003/Desktop/bookdata.csv");
        //    return View(books);
        //    //return View();
        //}

        //[HttpPost]
        //public ActionResult Upload(HttpPostedFileBase file)
        //{
        //if (file != null && file.ContentLength > 0)
        //{
        // Read and process the uploaded file
        //var books = ReadBooksFromCsv(file.InputStream);

        // You can save the books data or perform any other processing

        // Redirect to the index action to refresh the view
        //return RedirectToAction("Admin");
        //}

        // Handle the case where no file is uploaded
        //return RedirectToAction("Admin");
        //}

        // Implement your logic to load books from CSV file
        //private static List<Book> LoadBooksFromCsv(string filePath)
        //{
        // Your implementation here
        //}

        // Implement your logic to read books from CSV file stream
        //private static List<Book> ReadBooksFromCsv(Stream stream)
        //{
        // Your implementation here
        //}

        //private static List<Book> ReadBooksFromCsv(Stream stream)
        //{
        //using (var reader = new StreamReader(stream))
        //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        // {
        //var books = csv.GetRecords<Book>().ToList();
        //return books;
        //}
        //}


    }

    //public class HttpPostedFileBase
    //{
    //    internal readonly int ContentLength;
    //    internal readonly Stream? InputStream;
    //}
}

