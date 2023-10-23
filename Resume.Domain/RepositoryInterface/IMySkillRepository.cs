using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Domain.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillRepository
    {
        List<MySkills> GetListOfMySkills();
    }
}
