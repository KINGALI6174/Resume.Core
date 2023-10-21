using Microsoft.EntityFrameworkCore;
using Resume.Application.Interfaces;
using Resume.Domain.Entities.Education;
using Resume.Models.ResmeDbContext;


namespace Resume.Application.Implementations
{
    public class IEducationService : IEducationServicece
    {
        private ResumeDbContext _context;

        public IEducationService(ResumeDbContext contex)
        {
            _context = contex;
        }

        public async Task CreateAnEducation(Education education)
        {
            Education education1 = new Education();
            education1.EducationTitle = "Alioiii";
            education1.EducationDescription = "Ali Description";
            education1.EducationDuration = "2014-20-23";

            await _context.Educations.AddAsync(education1);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnEducation(int educationid)
        {
            Education education =  await GetAnEducationById(educationid);
        }

        public async Task<List<Education>> GetListOfEducations()
        {
            List<Education> EducationList = await _context.Educations.ToListAsync();
            return EducationList;
        }

        public async Task<Education> GetAnEducationById(int educationid)
        {
            Education? education = await _context.Educations
                .FirstOrDefaultAsync(p => p.ID == educationid);
            return education;
        }
    }
}
