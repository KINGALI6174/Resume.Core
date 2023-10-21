using Resume.Domain.Entities.Exprience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperienceRepository
    { 
        List<Exprience> GetListOfExperience();
    }
}
