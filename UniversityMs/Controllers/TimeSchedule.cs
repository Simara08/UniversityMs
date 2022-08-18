using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class TimeSchedule : Controller
    {
        public AppDbContext _context { get; }
        public TimeSchedule(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TimeScheduleVM time = new TimeScheduleVM
            {
                TimeSchedule=_context.TimeSchedule.ToList()
            };
            return View(time);
        }
    }
}
