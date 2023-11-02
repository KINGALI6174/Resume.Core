using Resume.Application.DTOs.SiteSide.Home_Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
    public interface IDashboardService
    {
        Task<HomeIndexModelDTO> FillDashboardModel();
    }
}
