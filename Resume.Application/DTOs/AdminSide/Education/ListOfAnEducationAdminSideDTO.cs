using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.AdminSide.Education
{
    public  class ListOfAnEducationAdminSideDTO
    {
        public int Id { get; set; }
        public string EducationTitle { get; set; }

        public string Duration { get;set; }
    }
}
