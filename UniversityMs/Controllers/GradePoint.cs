using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class GradePoint : Controller
    {
        public AppDbContext _context { get; }
        public GradePoint(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            GradePointVM gradep = new GradePointVM
            {
                GradePoint=_context.GradePoint.ToList()
            };
            return View(gradep);
        }
    }
}
