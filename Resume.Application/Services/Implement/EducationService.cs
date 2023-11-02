using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class EducationService : IEducationService
    {
        private readonly IEducationRepository _educationRepository;

        public EducationService(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public async Task AddEducationtoDataBase(CreateAnEducationAdminSideDTO model)
        {
            Education education = new Education();
            education.EducationTitle = model.EducationTitle;
            education.EducationDuration = model.EducationDuration;
            education.EducationDescription = model.EducationDescription;

            await _educationRepository.AddEducationToDataBase(education);
        }

        public async Task DeleteAnEducation(Education education)
        {
            await _educationRepository.DeleteAnEducation(education);
        }

        public async Task EditAnEducation(Education education)
        {
            await _educationRepository.EditAnEducation(education);
        }

        public async Task<Education> GetAnEducationById(int educationid)
        {
            return await _educationRepository.getAnEducationById(educationid);
        }

        public List<Education> GetEducationsList()
        {
            return _educationRepository.GetListOfEducation();
        }

        public List<ListOfAnEducationAdminSideDTO> GetListOfAnEducationAdminSideList()
        {
            List<Education> educations = _educationRepository.GetListOfEducation();
            List<ListOfAnEducationAdminSideDTO> returnModel = new List<ListOfAnEducationAdminSideDTO>();

            foreach (var edu in educations)
            {
                ListOfAnEducationAdminSideDTO childModel = new ListOfAnEducationAdminSideDTO();
                childModel.EducationTitle = edu.EducationTitle;
                childModel.Duration = edu.EducationDuration;
                childModel.Id = edu.ID;

                returnModel.Add(childModel);
            }
            return returnModel;
        }
    }
}
