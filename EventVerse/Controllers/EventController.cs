using Microsoft.AspNetCore.Mvc;

namespace EventVerse.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
