using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class DocErize : Controller
    {
        public AppDbContext _context { get; }
        public DocErize(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DocErizeVM erize = new DocErizeVM
            {
                DocErize=_context.DocErize.ToList()
            };
            return View(erize);
        }
    }
}
