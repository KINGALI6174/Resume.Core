using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Models.Entities.Education;

namespace Resume.Application.Interfaces
{
    public interface IEducationServicece
    {
        Task<List<Education>> GetListOfEducations();

        Task CreateAnEducation(Education education);
        Task DeleteAnEducation(int educationid);
        Task GetAnEducationById(int educationid);
    }
}
