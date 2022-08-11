using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Area("UniversityMsAdmin")]
    public class AboutpageController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public AboutpageController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Aboutpages.ToListAsync());
        }

        private string UploadedFile(Aboutpage about)
        {
            string uniqueFileName = null;

            if (about.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + about.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    about.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aboutpage about)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(about);

                about.Image = uniqueFileName;

                _context.Add(about);
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
            var about = await _context.Aboutpages.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Aboutpage about, int? id)
        {
            if (id != about.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldabout = await _context.Aboutpages.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldabout.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(about);

                    oldabout.Image = uniqueFileName;
                    oldabout.Title = about.Title;
                    oldabout.Content = about.Content;
                    _context.Update(oldabout);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutpagesExists(about.Id))
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

            var about = await _context.Aboutpages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var about = await _context.Aboutpages.FindAsync(id);
            _context.Aboutpages.Remove(about);


            string path = Path.Combine(_env.WebRootPath, "img", about.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool AboutpagesExists(int id)
        {
            return _context.Aboutpages.Any(e => e.Id == id);
        }
    }
}
