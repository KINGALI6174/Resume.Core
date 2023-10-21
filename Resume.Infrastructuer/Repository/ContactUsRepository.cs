using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Models.ResmeDbContext;

namespace Resume.Infrastructuer.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly ResumeDbContext _context;

        public ContactUsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        public async Task AddContactUsToDataBase(ContactUs contactUs)
        {
            await _context.ContactUs.AddAsync(contactUs);
            await _context.SaveChangesAsync();
        }
    }
}
