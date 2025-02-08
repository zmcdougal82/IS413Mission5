using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator() // ✅ Ensure this method exists
        {
            return View();
        }
    }
}