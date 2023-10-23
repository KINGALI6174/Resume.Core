using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository _contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        public async Task AddNewContactUsMessage(ContactUsDTO contactUsDTO)
        {
            ContactUsLocation location = new ContactUsLocation();

            location.Address = contactUsDTO.Address;

            ContactUs contact = new ContactUs();
            contact.FullName = contactUsDTO.FullName;
            contact.Mobile = contactUsDTO.Mobile;
            contact.Message = contactUsDTO.Message;

            await _contactUsRepository.AddContactUsToDataBase(contact);
            await _contactUsRepository.AddLocationToDataBase(location);

        }
    }
}