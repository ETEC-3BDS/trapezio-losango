using Microsoft.AspNetCore.Mvc;
using ProjTrapezio.Models;
using System.Diagnostics;

namespace ProjTrapezio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trapezio()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Trapezio(areaTrapezio t)
        {
            t.Area = ((t.Bma + t.Bme) * t.Altura) / 2;
            ViewBag.Area = t.Area;
            return View(ViewBag);
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
    }
}
