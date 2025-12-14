using Microsoft.AspNetCore.Mvc;
using TestSommee.Data;
using System.Linq;

namespace TestSommee.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
