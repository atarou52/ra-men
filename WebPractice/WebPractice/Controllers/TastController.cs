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
            return View();
        }

        public IActionResult Miso() 
        {
            return View();
        }
        public IActionResult Pigbones()
        {
            var tasts = DataSorce.DataSorce.Index();
            return View(tasts);
        }
        public IActionResult SoySorce()
        {
            return View();
        }

        public IActionResult Others()
        {
            return View();
        }
    }
}
