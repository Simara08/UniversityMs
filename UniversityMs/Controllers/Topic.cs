using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Topic : Controller
    {
        public AppDbContext _context { get; }
        public Topic(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TopicVM topic = new TopicVM
            {
                Topic=_context.Topic.ToList()
            };
            return View();
        }
    }
}
