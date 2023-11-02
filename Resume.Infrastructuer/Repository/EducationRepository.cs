using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Models.ResmeDbContext;

namespace Resume.Infrastructuer.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly ResumeDbContext _resumeDbContext;

        public EducationRepository(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }

        public async Task AddEducationToDataBase(Education education)
        {
            await _resumeDbContext.AddAsync(education);
            await _resumeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAnEducation(Education education)
        {
            _resumeDbContext.Educations.Remove(education);
            await _resumeDbContext.SaveChangesAsync();
        }

        public async Task EditAnEducation(Education education)
        {
            _resumeDbContext.Educations.Update(education);
            await _resumeDbContext.SaveChangesAsync();
        }

        public Task<Education> getAnEducationById(int educationid)
        {
            return _resumeDbContext.Educations.FirstOrDefaultAsync(p => p.ID == educationid);
        }

        public List<Education> GetListOfEducation()
        {
            return  _resumeDbContext.Educations.ToList();
        }
    }
}
