using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class About : Controller
    {
        private AppDbContext _context { get; }

        public About(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVM about = new AboutVM
            {
                Aboutpages=_context.Aboutpages.ToList(),
                Maps=_context.Maps.ToList()
            };
            return View(about);
        }
    }
}
