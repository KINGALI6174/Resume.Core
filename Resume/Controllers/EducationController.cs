using Microsoft.AspNetCore.Mvc;
using Resume.Models.Entities.Education;
using Resume.Models.ResmeDbContext;

namespace Resume.Controllers
{
    public class EducationController : Controller
    {
        

        [HttpGet]
        public async Task<IActionResult> ListOfEducation()
        {
            return View();
        }

        public async Task<IActionResult> CreatAnEducation()
        {
            return RedirectToAction(nameof(ListOfEducation));
        }
    }
}
