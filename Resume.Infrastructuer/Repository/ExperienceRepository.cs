using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Exprience;
using Resume.Domain.RepositoryInterface;
using Resume.Models.ResmeDbContext;

namespace Resume.Infrastructuer.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly ResumeDbContext _resumeDbContext;

        public ExperienceRepository(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }

        public List<Exprience> GetListOfExperience()
        {
            return _resumeDbContext.Expriences.ToList();
        }
    }
}
