using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Faculty : Controller
    {
        public AppDbContext _context { get; }
        public Faculty(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FacultyVM faculty = new FacultyVM
            {
                Faculty=_context.Faculty.ToList()
            };
            return View(faculty);
        }
    }
}
