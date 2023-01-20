using Microsoft.AspNetCore.Mvc;

namespace EventVerse.Controllers
{
    public class MerchandiseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddMerch()
        {
            return View();
        }
    }
}
