using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Domain.Entities.Education;

namespace Resume.Application.Services.Interface
{
    public interface IEducationService
    {
        List<Education> GetEducationsList();

        // Get List Of An Education For Show In Admin Panel
        List<ListOfAnEducationAdminSideDTO> GetListOfAnEducationAdminSideList();

        Task AddEducationtoDataBase(CreateAnEducationAdminSideDTO model);

        Task<Education> GetAnEducationById(int educationid);

        Task EditAnEducation(Education education);

        Task DeleteAnEducation(Education education);
    }
}
