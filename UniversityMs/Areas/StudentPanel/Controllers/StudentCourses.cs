using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Areas.StudentPanel.Controllers
{
    [Area("StudentPanel")]
    //[Authorize]
    public class StudentCourses : Controller
    {
        public AppDbContext _context { get; set; }
        public StudentCourses(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM coursedep = new CourseVM
            {
                Course = _context.Course.Include(x => x.CourseDep).ThenInclude(t => t.Department).ToList(),
            };
            return View(coursedep);
           

        }
        
    }
}
