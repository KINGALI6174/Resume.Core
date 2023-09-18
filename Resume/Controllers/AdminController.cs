using Microsoft.AspNetCore.Mvc;

namespace Resume.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
