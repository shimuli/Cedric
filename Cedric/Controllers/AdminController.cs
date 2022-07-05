using Cedric.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cedric.Controllers
{
    public class AdminController : Controller
    {
        private readonly portfolioDbContext _db;

        public AdminController(portfolioDbContext db)
        {
            _db = db;
        }
        public IActionResult AdminHomeView()
        {
            IEnumerable<Projetc> projects = _db.Projetcs.ToList();

            return View(projects);
        }
    }
}
