using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Turbo_Az.DAL;

namespace Turbo_Az.Controllers
{
    public class AjaxController : Controller
    {
        private readonly Db_Turbo _context;

        public AjaxController(Db_Turbo context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult LoadModelsByBrandId(int brandId)
        {
            return PartialView("_SelectModelsPartialView", _context.Models.Where(c => c.BrandId == brandId));
        }
    }
}