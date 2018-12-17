using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        //This is the about view
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        //This is the list all comics view
        public IActionResult ListAllComics()
        {
            ViewBag.Title = "List All Comics";
            return View();
        }

        //This is the edit comic view
        public IActionResult EditComic()
        {
            ViewBag.Title = "Edit Comic";
            return View();
        }
    }
}
