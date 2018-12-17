using Microsoft.AspNetCore.Mvc;

namespace ComicAspNetCore.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
