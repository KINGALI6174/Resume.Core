
using Resume.Domain.Entities.Education;
namespace Resume.Application.Interfaces
{
    public interface IEducationServicece
    {
        Task<List<Education>> GetListOfEducations();

        Task CreateAnEducation(Education education);
        Task DeleteAnEducation(int educationid);
        Task<Education> GetAnEducationById(int educationid);
    }
}
