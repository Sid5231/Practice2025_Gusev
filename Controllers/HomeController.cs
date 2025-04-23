using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice2025_Gusev.Models;
using System.Diagnostics;

namespace Practice2025_Gusev.Controllers
{
    public class HomeController : Controller
    {
        private readonly Practice2025Context _context;

        public HomeController(Practice2025Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var student = _context.students
                .Include(s => s.Group).ThenInclude(g => g.Specialty)
                .Include(s => s.Group).ThenInclude(g => g.Institute)
                .ToList();
            return View(student);
        }

        [HttpPost]
        public IActionResult Search(string groupNumber)
        {
            var student = _context.students
                .Include(s => s.Group).ThenInclude(g => g.Specialty)
                .Include(s => s.Group).ThenInclude(g => g.Institute)
                .Where(s => s.Group.group_number == groupNumber).ToList();

            return View("Index",student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
