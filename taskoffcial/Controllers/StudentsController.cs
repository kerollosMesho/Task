using Microsoft.AspNetCore.Mvc;
using taskoffcial.Data;
using taskoffcial.Models;

namespace taskoffcial.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentsController(ApplicationDbContext context)
        {

            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.students.ToList();
            return View(result);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            _context.students.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
