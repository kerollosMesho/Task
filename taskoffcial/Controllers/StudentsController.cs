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
            var result = _context.Students.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewBag.Subjects = _context.Subjects.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student, List<int> SelectedSubjects)
        {
            if (ModelState.IsValid)
            {
                // Add student to the database
                _context.Students.Add(student);
                _context.SaveChanges();

                // Link student with selected subjects
                foreach (var subjectId in SelectedSubjects)
                {
                    var studentSubject = new StudentSubject
                    {
                        StudentID = student.StudentID,
                        SubjectID = subjectId
                    };
                    _context.StudentSubjects.Add(studentSubject);
                }

                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Subjects = _context.Subjects.ToList();
            return View(student);

        }
    }
}
