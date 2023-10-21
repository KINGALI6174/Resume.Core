using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Models.ResmeDbContext;

namespace Resume.Infrastructuer.Repository
{
    public class MySkillRepository : IMySkillRepository
    {
        private readonly ResumeDbContext _resumeDbContext;

        public MySkillRepository(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }

        public List<MySkills> GetListOfMySkills()
        {
           return _resumeDbContext.MySkills.ToList();
        }
    }
}
