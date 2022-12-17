using Microsoft.AspNetCore.Mvc;

namespace WebPractice.Controllers
{
    public class DataController : Controller
    {
        public void Insert() 
        {
            //登録処理を実施
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
