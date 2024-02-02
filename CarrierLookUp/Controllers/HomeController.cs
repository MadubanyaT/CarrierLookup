using Microsoft.AspNetCore.Mvc;

namespace CarrierLookUp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string s)
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
