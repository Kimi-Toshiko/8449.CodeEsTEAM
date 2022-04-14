using _8449.CodeEsTEAM.WebApp.DAL;
using _8449.CodeEsTEAM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _8449.CodeEsTEAM.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CodeEsTeamDBContext _db;

        public HomeController(ILogger<HomeController> logger, CodeEsTeamDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Course> objCoursesList = _db.Courses;
            return View(objCoursesList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course obj)
        {
            if (ModelState.IsValid)
            {
                _db.Courses.Add(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Details(int? id)
        {
            var courseFromDb = _db.Courses.Find(id);
            return View(courseFromDb);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            var courseFromDb = _db.Courses.Find(id);
            return View(courseFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Course obj)
        {
            if (ModelState.IsValid)
            {
                _db.Courses.Update(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            var courseFromDb = _db.Courses.Find(id);
            return View(courseFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Courses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Courses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult About()
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