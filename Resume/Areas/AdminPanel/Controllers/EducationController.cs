using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;

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

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnEducation(CreateAnEducationAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _educationService.AddEducationtoDataBase(model);
                return RedirectToAction("ListOfAnEducation", "Education");
            }

            return View();
        }

        public async Task<IActionResult> EditAnEducation(int educationid)
        {
            var education = await _educationService.GetAnEducationById(educationid);
            return View(education);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnEducation(Education education)
        {
            await _educationService.EditAnEducation(education);
            return RedirectToAction(nameof(ListOfAnEducation));
            return View(education);
        }

        public async Task<IActionResult> DeleteAnEducation(int educationid)
        {
            var education = await _educationService.GetAnEducationById(educationid);
            return View(education);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnEducation(Education education)
        {
            await _educationService.DeleteAnEducation(education);
            return RedirectToAction(nameof(ListOfAnEducation));
            return View(education);
        }
    }
}
