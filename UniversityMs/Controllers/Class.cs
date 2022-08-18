using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Class : Controller
    {
        public AppDbContext _context { get; }
        public Class(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ClassVM group = new ClassVM
            {
                Class = _context.Class.ToList()
            };

            return View(group);
        }
    }
}
