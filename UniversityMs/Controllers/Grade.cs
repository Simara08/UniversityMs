using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Grade : Controller
    {
        public AppDbContext _context { get; }
        public Grade(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            GradeVM grade = new GradeVM
            {
                Grade=_context.Grade.ToList()
            };
            return View(grade);
        }
    }
}
