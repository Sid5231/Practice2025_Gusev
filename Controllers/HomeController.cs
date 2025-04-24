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

        public async Task<IActionResult> Index()
        {
            try
            {
                var students = await _context.students
                .Include(s => s.Group).ThenInclude(g => g.Specialty)
                .Include(s => s.Group).ThenInclude(g => g.Institute)
                .ToListAsync();
                return View(students);
            }
            catch (Exception ex)
            {
                return View("Ошибка при загрузке списка студентов");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Search(string groupNumber)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(groupNumber))
                {
                    return View("Index", new List<Student>());
                }

                var students = await _context.students
                .Include(s => s.Group).ThenInclude(g => g.Specialty)
                .Include(s => s.Group).ThenInclude(g => g.Institute)
                .Where(s => s.Group != null && s.Group.GroupNumber == groupNumber).ToListAsync();

                return View("Index", students);
            }
            catch(Exception ex)
            {
                return View("Ошибка при поиске студентов");
            }
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
