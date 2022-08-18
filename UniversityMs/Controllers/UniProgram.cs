using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class UniProgram : Controller
    {
        public AppDbContext _context { get; }
        public UniProgram(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            UniProgramVM program = new UniProgramVM
            {
                UniProgram=_context.Program.ToList()
            };
            return View(program);
        }
    }
}
