﻿using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Exprience;
using Resume.Domain.Entities.MySkills;

namespace Resume.Models.ResmeDbContext
{
    public class ResumeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-K81JHQ4;Initial Catalog =ResumeDbContext;Integrated Security=True;multipleActiveResultSets=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Exprience> Expriences { get; set; }

        public DbSet<MySkills> MySkills { get; set; }

        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<ContactUsLocation> ContactUsLocations { get; set; }
    }
}
