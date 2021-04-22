using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello(string name, int times = 1)
        {
            ViewData["name"] = "Hello, " + name;
            ViewData["times"] = times;

            return View();
        }
    }
}
