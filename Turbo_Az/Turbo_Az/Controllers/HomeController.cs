using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo_Az.DAL;
using Turbo_Az.Models;
using Turbo_Az.Utilities;
using Turbo_Az.ViewModel;

namespace Turbo_Az.Controllers
{
    public class HomeController : Controller
    {
        private readonly Db_Turbo _context;
        UserManager<AppUser> userManager;
        RoleManager<IdentityRole> roleManager;

        public HomeController(Db_Turbo context,
                              UserManager<AppUser> _userManager,
                              RoleManager<IdentityRole> _roleManager)
        {
                _context = context;
            userManager = _userManager;
            roleManager = _roleManager;
        }

        public ActionResult Index()
        {
            AdNewsModel viewModel = new AdNewsModel(){

                Advertisements = _context.Advertisements.Include(ad => ad.MachinePower)
                                .Include(ad => ad.City)
                                .Include(ad => ad.GradiuationYear)
                                .Include(ad => ad.Model)
                                .ThenInclude(model => model.Brand),
                News = _context.News
            };
            
            return View(viewModel);
        }

        public async Task<IActionResult> CarDetails(int? id)
        {
            if (id == null) return NotFound();

            Advertisement ad = await _context.Advertisements.Include(a => a.MachinePower)
                                .Include(a => a.City)
                                .Include(a => a.Color)
                                .Include(a => a.Speed)
                                .Include(a => a.Fuel)
                                .Include(a => a.GradiuationYear)
                                .Include(a => a.Model)
                                .ThenInclude(m => m.Brand)
                                .FirstOrDefaultAsync(a => a.Id == id);
                                                            

            if (ad == null) return NotFound();

            return View(ad);
        }

        public async Task<IActionResult> NewsDetails(int? id)
        {
            if (id == null) return NotFound();

            News news = await _context.News.FindAsync(id);


            if (news == null) return NotFound();

            return View(news);
        }

        public IActionResult News()
        {
            return View(_context.News);
        }

        public IActionResult Advertisement()
        {
            ViewBag.Model = _context.Model;
            ViewBag.Brand = _context.Brands;
            ViewBag.Colors = _context.Colors;
            ViewBag.Fuels = _context.Fuels;
            ViewBag.MachinePowers = _context.MachinePowers;
            ViewBag.GraduationYears = _context.GradiuationYears;
            ViewBag.Speeds = _context.Speeds;
            ViewBag.Cities = _context.Cities;


            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Advertisement(Advertisement advertisement)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Model = _context.Model;
                ViewBag.Brand = _context.Brands;
                ViewBag.Colors = _context.Colors;
                ViewBag.Fuels = _context.Fuels;
                ViewBag.MachinePowers = _context.MachinePowers;
                ViewBag.GraduationYears = _context.GradiuationYears;
                ViewBag.Speeds = _context.Speeds;
                ViewBag.Cities = _context.Cities;
                ModelState.AddModelError("", "Please input valid properties");

                return View(advertisement);

            }

            Advertisement ad = new Advertisement()
            {
                ModelId = advertisement.ModelId,
                Price = advertisement.Price,
                ColorId = advertisement.ColorId,
                MachinePowerId = advertisement.MachinePowerId,
                FuelId = advertisement.FuelId,
                Hiking = advertisement.Hiking,
                GradiuationYearId = advertisement.GradiuationYearId,
                SpeedId = advertisement.SpeedId,
                CarInfo = advertisement.CarInfo,
                CityId = advertisement.CityId,
                AdYear = DateTime.Now,
            };

            _context.Advertisements.Add(ad);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
