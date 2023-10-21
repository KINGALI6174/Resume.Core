using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Exprience;
using Resume.Models.ResmeDbContext;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEducationRepository _educationRepository;
		private readonly IExperienceRepository _experienceRepository;
		private readonly IMySkillRepository _mySkillRepository;

        public HomeController(IEducationRepository educationRepository,
                              IExperienceRepository experienceRepository,
                              IMySkillRepository mySkillRepository)
        {
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
            _mySkillRepository = mySkillRepository;
        }


        public async Task<IActionResult> Index()
        {
            List<MySkills> MySkill = _mySkillRepository.GetListOfMySkills();
            List<Education> educations = _educationRepository.GetListOfEducation();
            List<Exprience> expriences = _experienceRepository.GetListOfExperience();

			HomeIndexModelDTO model = new HomeIndexModelDTO();
			model.Educations = educations;
			model.Exprience = expriences;
			model.Myskiils = MySkill;

            return View(model);
		}

		public IActionResult About()
		{
			return View();
		}

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}