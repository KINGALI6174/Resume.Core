using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities.ContactUs
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsSeenByAdmin { get; set; }
    }
}
