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
    public class ProjectController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public ProjectController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Projects.ToListAsync());
        }

        private string UploadedFile(Project proj)
        {
            string uniqueFileName = null;

            if (proj.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + proj.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    proj.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(Project proj)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(proj);

                proj.Image = uniqueFileName;

                _context.Add(proj);
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
            var proj = await _context.Projects.FindAsync(id);
            if (proj == null)
            {
                return NotFound();
            }
            return View(proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Project proj, int? id)
        {
            if (id != proj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldproj = await _context.Projects.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldproj.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(proj);

                    oldproj.Image = uniqueFileName;
                    oldproj.Title = proj.Title;
                    oldproj.Desc = proj.Desc;
                    oldproj.ImgTitle = proj.ImgTitle;
                    oldproj.ImgDesc = proj.ImgDesc;
                    _context.Update(oldproj);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectsExists(proj.Id))
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

            var proj = await _context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proj == null)
            {
                return NotFound();
            }

            return View(proj);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var proj = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(proj);


            string path = Path.Combine(_env.WebRootPath, "img", proj.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ProjectsExists(int id)
        {
            return _context.Graduates.Any(e => e.Id == id);
        }
    }
}
