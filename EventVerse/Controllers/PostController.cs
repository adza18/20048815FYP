using Microsoft.AspNetCore.Mvc;

namespace EventVerse.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
