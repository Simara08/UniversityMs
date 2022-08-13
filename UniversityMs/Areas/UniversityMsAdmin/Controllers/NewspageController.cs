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
using Newspage = UniversityMs.Models.Newspage;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Authorize]
    [Area("UniversityMsAdmin")]
        public class NewspageController : Controller
        {
            private AppDbContext _context { get; }
            private IWebHostEnvironment _env { get; }
            public NewspageController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }

            public async Task<IActionResult> Index()
            {
                return View(await _context.Newspages.ToListAsync());
            }

            private string UploadedFile(Newspage news)
            {
                string uniqueFileName = null;

                if (news.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + news.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        news.Photo.CopyTo(fileStream);
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
            public async Task<IActionResult> Create(Newspage news)
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = UploadedFile(news);

                    news.Image = uniqueFileName;

                    _context.Add(news);
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
                var news = await _context.Newspages.FindAsync(id);
                if (news == null)
                {
                    return NotFound();
                }
                return View(news);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Update(Newspage news, int? id)
            {
                if (id != news.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        var oldnews = await _context.Newspages.FindAsync(id);
                        string path = Path.Combine(_env.WebRootPath, "img", oldnews.Image);

                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }


                        string uniqueFileName = UploadedFile(news);

                        oldnews.Image = uniqueFileName;
                        oldnews.Title = news.Title;
                        oldnews.Newstitle = news.Newstitle;
                        oldnews.Desc = news.Desc;
                        oldnews.Content = news.Content;
                        _context.Update(oldnews);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!NewspagesExists(news.Id))
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

                var news = await _context.Newspages
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (news == null)
                {
                    return NotFound();
                }

                return View(news);
            }

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {




                var news = await _context.Newspages.FindAsync(id);
                _context.Newspages.Remove(news);


                string path = Path.Combine(_env.WebRootPath, "img", news.Image);


                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            private bool NewspagesExists(int id)
            {
                return _context.Newspages.Any(e => e.Id == id);
            }
        }
}
