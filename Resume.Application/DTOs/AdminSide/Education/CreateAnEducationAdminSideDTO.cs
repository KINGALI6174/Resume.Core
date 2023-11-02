using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.AdminSide.Education
{
    public class CreateAnEducationAdminSideDTO
    {
        public string EducationTitle { get; set; }
        public string EducationDescription { get; set; }
        public string EducationDuration { get; set; }
    }
}
