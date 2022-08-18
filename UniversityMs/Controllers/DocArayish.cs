using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class DocArayish : Controller
    {
        public AppDbContext _context { get; }
        public DocArayish(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DocArayishVM arayish = new DocArayishVM
            {
                DocArayish=_context.DocArayish.ToList()
            };
            return View(arayish);
        }
    }
}
