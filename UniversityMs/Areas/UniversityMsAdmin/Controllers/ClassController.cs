using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    //[Authorize]
    [Area("UniversityMsAdmin")]
    public class ClassController : Controller
    {
       
            private AppDbContext _context { get; }
            private IWebHostEnvironment _env { get; }
            public ClassController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }

            public async Task<IActionResult> Index()
            {
                return View(await _context.Class.ToListAsync());
            }
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Class group)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(group);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            public async Task<IActionResult> Update(int? id)
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var group = await _context.Class.FindAsync(id);
                if (group == null)
                {
                    return NotFound();
                }
                return View(group);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Update(Class group, int? id)
            {
                if (id != group.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        var oldabout = await _context.Aboutpages.FindAsync(id);
                        oldabout.Title = group.Title;
                        _context.Update(oldabout);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ClassExists(group.Id))
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
                return View();
            }

            // GET: AdminPanel/Services/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var group = await _context.Class
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (group == null)
                {
                    return NotFound();
                }

                return View(group);
            }

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var group = await _context.Class.FindAsync(id);
                _context.Class.Remove(group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            private bool ClassExists(int id)
            {
                return _context.Aboutpages.Any(e => e.Id == id);
            }
    }
}
