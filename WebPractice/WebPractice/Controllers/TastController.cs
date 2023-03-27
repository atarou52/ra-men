using Microsoft.AspNetCore.Mvc;
using WebPractice.DataSorce;
using WebPractice.Models;

namespace WebPractice.Controllers
{
    public class TastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Solt()
        {
            var tasts = DataSorce.DataSorce.Index("Solt");
            return View(tasts);
        }

        public IActionResult Miso() 
        {
            var tasts = DataSorce.DataSorce.Index("Miso");
            return View(tasts);
        }
        public IActionResult Pigbones()
        {
            var tasts = DataSorce.DataSorce.Index("Pigbones");
            return View(tasts);
        }
        public IActionResult SoySorce()
        {
            var tasts = DataSorce.DataSorce.Index("SoySorce");
            return View(tasts);
        }

        public IActionResult Others()
        {
            var tasts = DataSorce.DataSorce.Index("all");
            return View(tasts);
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
