using CarrierLookUp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

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
        public IActionResult Index(UserInput Number)
        {
            //The number must be sanitized before it gets to the checker

            if (ModelState.IsValid && Regex.IsMatch(Number.CNumber, @"^0[1-9]\d{8}$"))
            {
                NumberChecker numberChecker = new NumberChecker(Number);
                Number.Carrier = numberChecker.Carrier;
                return View(Number);
            }
            return View(null);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
