using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Domain.Entities.Education;

namespace Resume.Domain.RepositoryInterface
{
    public interface IEducationRepository
    {
        List<Education> GetListOfEducation();
        Task AddEducationToDataBase(Education education);
    }
}
