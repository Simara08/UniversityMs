using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Exam : Controller
    {
        public AppDbContext _context { get; }
        public Exam(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ExamVM exam = new ExamVM
            {
                Exam=_context.Exam.ToList()
            };
            return View(exam);
        }
    }
}
