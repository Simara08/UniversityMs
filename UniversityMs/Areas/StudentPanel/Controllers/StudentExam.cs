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
    public class StudentExam : Controller
    {
        public AppDbContext _context { get; set; }
        public StudentExam(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM coursequiz = new CourseVM
            {
                Course=_context.Course.Include(x=>x.CourseSturucture).ThenInclude(c=>c.SectionCourseStruc).ThenInclude(t=>t.ExamCourseStruc).ThenInclude(z=>z.Exam).ToList()
            };
            return View(coursequiz);    
        }
    }
}
