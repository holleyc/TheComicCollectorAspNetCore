using Microsoft.AspNetCore.Mvc;
using System;

namespace ComicAspNetCore.Controllers
{
    public class AppController : Controller
    {
        //This is the Index view
        public IActionResult Index()
        {
            return View();
        }

        //This is the contacts view
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            throw new InvalidOperationException("Bad things happen");

            return View();
        }

        //This is the about view
        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        //This is the list all comics view
        [HttpGet("listallcomics")]
        public IActionResult ListAllComics()
        {
            ViewBag.Title = "List All Comics";
            return View();
        }

        //This is the edit comic view
        [HttpGet("editcomic")]
        public IActionResult EditComic()
        {
            ViewBag.Title = "Edit Comic";
            return View();
        }
    }
}
