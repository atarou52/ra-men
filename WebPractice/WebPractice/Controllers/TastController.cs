using Microsoft.AspNetCore.Mvc;

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
            return View();
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
