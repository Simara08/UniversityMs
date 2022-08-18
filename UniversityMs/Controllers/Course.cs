using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Course : Controller
    {
        public AppDbContext _context { get; }
        public Course(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM course = new CourseVM
            {
                Course=_context.Course.ToList()
            };
            return View(course);
        }
    }
}
