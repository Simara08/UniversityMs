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
    public class StudentQuiz : Controller
    {
        public AppDbContext _context { get; set; }
        public StudentQuiz(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM coursequiz = new CourseVM
            {
                Course = _context.Course.Include(y => y.CourseSturucture).ThenInclude(z => z.SectionCourseStruc).ThenInclude(c => c.CourseQuiz).ThenInclude(b => b.Quiz).ToList()
            };
            return View(coursequiz);
        }
    }
}
