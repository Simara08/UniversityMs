using Microsoft.AspNetCore.Authorization;
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

    [Authorize]
    [Area("UniversityMsAdmin")]
    public class DepartmentController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public DepartmentController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Department.ToListAsync());
        }

        private string UploadedFile(Department dep)
        {
            string uniqueFileName = null;

            if (dep.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + dep.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    dep.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(Department dep)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(dep);

                dep.Image = uniqueFileName;

                _context.Add(dep);
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
            var dep = await _context.Department.FindAsync(id);
            if (dep == null)
            {
                return NotFound();
            }
            return View(dep);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Department dep, int? id)
        {
            if (id != dep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var olddep = await _context.Department.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", olddep.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(dep);

                    olddep.Image = uniqueFileName;
                    olddep.Name = dep.Name;
                    olddep.Desc = dep.Desc;
                    olddep.Date = dep.Date;
                    _context.Update(olddep);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(dep.Id))
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

            var dep = await _context.Department
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dep == null)
            {
                return NotFound();
            }

            return View(dep);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var dep = await _context.Department.FindAsync(id);
            _context.Department.Remove(dep);


            string path = Path.Combine(_env.WebRootPath, "img", dep.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool DepartmentExists(int id)
        {
            return _context.Department.Any(e => e.Id == id);
        }
    }
}
