using Microsoft.AspNetCore.Mvc;
using TestSommee.Data;
using System.Linq;

namespace TestSommee.Controllers
{
    public class MonHocController : Controller
    {
        private readonly AppDbContext _context;

        public MonHocController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var monHoc = _context.MonHocs.ToList();
            return View(monHoc);
        }
    }
}
