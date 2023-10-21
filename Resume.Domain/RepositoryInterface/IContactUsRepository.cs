using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Domain.Entities.ContactUs;

namespace Resume.Domain.RepositoryInterface
{
    public interface IContactUsRepository
    {
        Task AddContactUsToDataBase(ContactUs contactUs);
    }
}
