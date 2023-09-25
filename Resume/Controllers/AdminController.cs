using Microsoft.AspNetCore.Mvc;

namespace Resume.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email,string password)
        {
            return View();
        }
    }
}
