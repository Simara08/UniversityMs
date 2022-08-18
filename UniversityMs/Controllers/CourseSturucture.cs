using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class CourseSturucture : Controller
    {
        public AppDbContext _context { get; }
        public CourseSturucture(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseStructureVM coursest = new CourseStructureVM
            {
                CourseSturucture=_context.CourseSturucture.ToList()
            };
            return View(coursest);
        }
    }
}
