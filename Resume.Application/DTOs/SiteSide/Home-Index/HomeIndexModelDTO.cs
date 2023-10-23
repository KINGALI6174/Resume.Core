using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.SiteSide.Home_Index
{
    public class HomeIndexModelDTO
    {
        public List<Resume.Domain.Entities.Education.Education> Educations;
        public List<Resume.Domain.Entities.Exprience.Exprience> Exprience;
        public List<Resume.Domain.Entities.MySkills.MySkills> Myskiils;
    }
}
