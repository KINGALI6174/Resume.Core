using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;

namespace Resume.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet]
        public IActionResult ListOfAnEducation()
        {
            var model = _educationService.GetEducationsList();
            return View(model);
        }

        public IActionResult CreateAnEducation()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnEducation(CreateAnEducationAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _educationService.AddEducationtoDataBase(model);
                return RedirectToAction("ListOfAnEducation", "Education");
            }
            return View();
        }
    }
}
