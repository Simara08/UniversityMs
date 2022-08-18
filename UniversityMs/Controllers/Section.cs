using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Section : Controller
    {
        public AppDbContext _context { get; }
        public Section(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SectionVM section = new SectionVM
            {
                Section=_context.Section.ToList()
            };
            return View(section);
        }
    }
}
