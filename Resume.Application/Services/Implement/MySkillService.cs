using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class MySkillService : IMySkillService
    {
        private readonly IMySkillRepository _skillRepository;

        public MySkillService(IMySkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public List<MySkills> getListOfMySkills()
        {
            return _skillRepository.GetListOfMySkills();
        }
    }
}
