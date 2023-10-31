using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using NToastNotify;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Exprience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class DashboardService : IDashboardService
    {
        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;
        private readonly IMySkillService _mySkillService;


        public DashboardService(IEducationService educationService,
                                IExperienceService experienceService,
                                IMySkillService mySkillService)
        {
            _educationService = educationService;
            _experienceService = experienceService;
            _mySkillService = mySkillService;
        }

        public async Task<HomeIndexModelDTO> FillDashboardModel()
        {
            List<MySkills> MySkill = _mySkillService.getListOfMySkills();
            List<Education> educations = _educationService.GetEducationsList();
            List<Exprience> expriences = _experienceService.GetExperienceList();
            HomeIndexModelDTO model = new HomeIndexModelDTO();
            model.Educations = educations;
            model.Exprience = expriences;
            model.Myskiils = MySkill;

            return model;
        }
    }
}
