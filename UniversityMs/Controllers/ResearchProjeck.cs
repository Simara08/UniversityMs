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
            ResearchProjeckVM rproject = new ResearchProjeckVM
            {
                ResearchProjeck=_context.ResearchProjeck.ToList()
            };
            return View(rproject);
        }
    }
}
