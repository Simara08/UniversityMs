using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Area("UniversityMsAdmin")]
    public class CourseSturucturesController : Controller
    {
        private readonly AppDbContext _context;

        public CourseSturucturesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UniversityMsAdmin/CourseStuructures
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CourseSturucture.Include(c => c.Course);
            return View(await appDbContext.ToListAsync());
        }


        // GET: UniversityMsAdmin/CourseStuructures/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id");
            return View();
        }

        // POST: UniversityMsAdmin/CourseStuructures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LectureNo,IsDaleted,Attendance,CourseId")] CourseSturucture courseSturucture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseSturucture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id", courseSturucture.CourseId);
            return View(courseSturucture);
        }

        // GET: UniversityMsAdmin/CourseStuructures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseSturucture = await _context.CourseSturucture.FindAsync(id);
            if (courseSturucture == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id", courseSturucture.CourseId);
            return View(courseSturucture);
        }

        // POST: UniversityMsAdmin/CourseStuructures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LectureNo,IsDaleted,Attendance,CourseId")] CourseSturucture courseSturucture)
        {
            if (id != courseSturucture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseSturucture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseStuructureExists(courseSturucture.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id", courseSturucture.CourseId);
            return View(courseSturucture);
        }

        // GET: UniversityMsAdmin/CourseStuructures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseSturucture = await _context.CourseSturucture
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseSturucture == null)
            {
                return NotFound();
            }

            return View(courseSturucture);
        }

        // POST: UniversityMsAdmin/CourseStuructures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseSturucture = await _context.CourseSturucture.FindAsync(id);
            _context.CourseSturucture.Remove(courseSturucture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseStuructureExists(int id)
        {
            return _context.CourseSturucture.Any(e => e.Id == id);
        }
    }
}
