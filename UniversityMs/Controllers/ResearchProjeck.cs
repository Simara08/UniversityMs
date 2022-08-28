using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class ResearchProjeck : Controller
    {
        public AppDbContext _context { get; }
        public ResearchProjeck(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ResearchProjectVM rproject = new ResearchProjectVM
            {
                ResearchProject=_context.ResearchProject.ToList()
            };
            return View(rproject);
        }
    }
}
