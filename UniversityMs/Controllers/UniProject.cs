using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class UniProject : Controller
    {
        public AppDbContext _context { get; }
        public UniProject(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            UniProjectVM proj = new UniProjectVM
            {
                UniProject=_context.UniProject.ToList()
            };
            return View(proj);
        }
    }
}
