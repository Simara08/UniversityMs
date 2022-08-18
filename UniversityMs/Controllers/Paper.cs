using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Paper : Controller
    {
        public AppDbContext _context { get; }
        public Paper(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PaperVM paper = new PaperVM
            {
                Paper=_context.Paper.ToList()
            };
            return View(paper);
        }
    }
}
