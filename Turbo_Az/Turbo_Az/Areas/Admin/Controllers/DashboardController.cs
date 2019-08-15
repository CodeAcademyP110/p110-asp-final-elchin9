using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Turbo_Az.DAL;
using Turbo_Az.Extensions;
using Turbo_Az.Models;

namespace Turbo_Az.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        
        private readonly Db_Turbo _context;
        private readonly IHostingEnvironment _env;

        public DashboardController(Db_Turbo context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.News);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.News.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> DeleteGet(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.News.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            News news = await _context.News.FindAsync(id);

            _context.News.Remove(news);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Advertisement()
        {
            return View(_context.Advertisements.Include(a => a.MachinePower)
                                .Include(a => a.City)
                                .Include(a => a.Color)
                                .Include(a => a.Speed)
                                .Include(a => a.Fuel)
                                .Include(a => a.GradiuationYear)
                                .Include(a => a.Model)
                                .ThenInclude(m => m.Brand));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news) 
        {

            if (!ModelState.IsValid)
            {
                return View(news);
            }

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(news);
            }

            if (!news.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type should be image");
                return View(news);
            }

            string filename = await news.Photo.SaveAsync(_env.WebRootPath);
            news.PhotoURL = filename;

            News mynews = new News()
            {
                Title = news.Title,
                ShortInfo = news.ShortInfo,
                MainInfo = news.MainInfo,
                PhotoURL = filename,
                Time = DateTime.Now,
            };
            
            await _context.News.AddAsync(mynews);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}