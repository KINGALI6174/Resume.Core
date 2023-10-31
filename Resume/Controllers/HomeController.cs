using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Exprience;
using Resume.Models.ResmeDbContext;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using NToastNotify;
using Resume.Application.Services.Interface;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDashboardService _boardService;
        private readonly IContactUsService _contactUsService;
        private readonly IToastNotification _toastNotification;
        private readonly INotyfService _notificationService;

        public HomeController(IDashboardService boardService)
        {
            _boardService = boardService;
        }


        public async Task<IActionResult> Index()
        {
            var model = await _boardService.FillDashboardModel();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }




        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost , ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(ContactUsDTO contactUsDTO)
        {
            await _contactUsService.AddNewContactUsMessage(contactUsDTO);
            _notificationService.Success("پیغام شما با موفقیت ثبت شد");
            return RedirectToAction("Contact");
            
        
        }



        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        
    }
}