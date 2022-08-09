using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Home : Controller
    {
        private AppDbContext _context { get;  }

        public Home(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM 
            {
                Slides=_context.Slides.ToList(),
                Graduates = _context.Graduates.ToList(),
                Projects=_context.Projects.ToList(),
                Partners=_context.Partners.ToList(),
                Mezunlar=_context.Mezunlar.ToList(),
            };
            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
