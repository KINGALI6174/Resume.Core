using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Implement;
using Resume.Application.Services.Interface;

namespace Resume.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


