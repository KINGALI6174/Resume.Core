using Microsoft.AspNetCore.Mvc;
using Resume.Models.Entities.Education;
using Resume.Models.ResmeDbContext;

namespace Resume.Controllers
{
    public class EducationController : Controller
    {
        private ResumeDbContext _context;

        public EducationController(ResumeDbContext contex)
        {
            _context = contex;
        }

        [HttpGet]
        public IActionResult ListOfEducation()
        {
            List<Education> ListOfEducation = _context.Educations.ToList();
            return View();
        }

        public IActionResult CeratAnEducation()
        {

            return View();
        }
    }
}
