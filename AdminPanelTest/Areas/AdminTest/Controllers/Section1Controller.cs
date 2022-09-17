using AdminPanelTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelTest.Areas.AdminTest.Controllers
{
    [Area("AdminTest")]
    public class Section1Controller : Controller
    {
        private readonly TestContext _context;

        public Section1Controller(TestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Section1ss.FirstOrDefault());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Section1 section1)
        {
            _context.Section1ss.Add(section1);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var section1  =_context.Section1ss.Find(id);
            return View(section1);
        }
        [HttpPost]
        public IActionResult Edit (Section1 section1)
        {

            _context.Section1ss.Update(section1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Section1 section1,int id)
        {

            var Section1 = _context.Section1ss.Find(id);
            _context.Section1ss.Remove(section1);
            _context.SaveChanges();
            return RedirectToAction(nameof (Index));
        }

        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var section1 =_context.Section1ss.FirstOrDefault(x=>x.Id == id);
            return View (section1);
        }
        public IActionResult Back()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
