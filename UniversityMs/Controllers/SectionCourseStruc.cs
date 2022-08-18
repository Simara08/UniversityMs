using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class SectionCourseStruc : Controller
    {
        public AppDbContext _context { get; }
        public SectionCourseStruc(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SectionCourseStrucVM sectioncoursest = new SectionCourseStrucVM
            {
               SectionCourseStruc= _context.SectionCourseStruc.ToList()
            };
            return View(sectioncoursest);
        }
    }
}
