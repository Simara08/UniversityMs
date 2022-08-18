using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class SemOffering : Controller
    {
        public AppDbContext _context { get; }
        public SemOffering(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SemOfferingVM semoff = new SemOfferingVM
            {
                SemOffering=_context.SemOffering.ToList()
            };
            return View(semoff);
        }
    }
}
