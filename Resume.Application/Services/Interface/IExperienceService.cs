using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Domain.Entities.Exprience;

namespace Resume.Application.Services.Interface
{
    public interface IExperienceService
    {
        List<Exprience> GetExperienceList();
    }
}
