using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Department : Controller
    {
        public AppDbContext _context { get; }
        public Department(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DepartmentVM dep = new DepartmentVM
            {
                Department=_context.Department.ToList()
            };
            return View(dep);
        }
    }
}
