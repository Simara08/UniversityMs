using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Quiz : Controller
    {
        public AppDbContext _context { get; }
        public Quiz(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            QuizVM quiz = new QuizVM
            {
                Quiz=_context.Quiz.ToList()
            };
            return View(quiz);
        }
    }
}
