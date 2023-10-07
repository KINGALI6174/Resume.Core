using Microsoft.AspNetCore.Mvc;
using Resume.Application.Implementations;
//using Resume.Models.Entities.Education;
//using Resume.Models.ResmeDbContext;

namespace Resume.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }
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
