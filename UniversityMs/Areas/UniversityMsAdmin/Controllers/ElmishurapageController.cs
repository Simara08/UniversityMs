using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Controllers;
using UniversityMs.DAL;
using UniversityMs.Migrations;
using UniversityMs.Models;
using Elmishurapage = UniversityMs.Models.Elmishurapage;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    //[Authorize]
    [Area("UniversityMsAdmin")]
    public class ElmishurapageController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public ElmishurapageController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Elmishuralar.ToListAsync());
        }

        private string UploadedFile(Elmishurapage elmishura)
        {
            string uniqueFileName = null;

            if (elmishura.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + elmishura.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    elmishura.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(Elmishurapage elmishura)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(elmishura);

                elmishura.Image = uniqueFileName;

                _context.Add(elmishura);
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
            var elmishura = await _context.Elmishuralar.FindAsync(id);
            if (elmishura == null)
            {
                return NotFound();
            }
            return View(elmishura);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Elmishurapage elmishura, int? id)
        {
            if (id != elmishura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldelmishura = await _context.Elmishuralar.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldelmishura.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(elmishura);

                    oldelmishura.Image = uniqueFileName;
                    oldelmishura.Title = elmishura.Title;
                    oldelmishura.Content = elmishura.Content;
                    _context.Update(oldelmishura);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElmishuralarExists(elmishura.Id))
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

            var elmishura = await _context.Elmishuralar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elmishura == null)
            {
                return NotFound();
            }

            return View(elmishura);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var elmishura = await _context.Elmishuralar.FindAsync(id);
            _context.Elmishuralar.Remove(elmishura);


            string path = Path.Combine(_env.WebRootPath, "img", elmishura.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ElmishuralarExists(int id)
        {
            return _context.Elmishuralar.Any(e => e.Id == id);
        }
    }
}
