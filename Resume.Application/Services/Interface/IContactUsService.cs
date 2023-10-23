using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Application.DTOs.SiteSide.ContactUs;

namespace Resume.Application.Services.Interface
{
    public interface IContactUsService
    {
        Task AddNewContactUsMessage(ContactUsDTO contactUsDTO);
    }
}
