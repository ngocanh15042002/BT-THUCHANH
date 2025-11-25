using Microsoft.AspNetCore.Mvc;

namespace DemoMVC061.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}   