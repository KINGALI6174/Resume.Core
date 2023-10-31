using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Exprience;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;

        public ExperienceService(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }
        public List<Exprience> GetExperienceList()
        {
            return _experienceRepository.GetListOfExperience();
        }
    }
}
