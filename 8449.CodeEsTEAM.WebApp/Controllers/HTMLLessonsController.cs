using _8449.CodeEsTEAM.WebApp.DAL;
using _8449.CodeEsTEAM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8449.CodeEsTEAM.WebApp.Controllers
{
    public class HTMLLessonsController : Controller
    {
        private readonly CodeEsTeamDBContext _db;

        public HTMLLessonsController(CodeEsTeamDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<HTMLLesson> objHtmlLessonsList = _db.HTMLLessons;
            return View(objHtmlLessonsList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HTMLLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.HTMLLessons.Add(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Details(int? id)
        {
            var htmlLessonFromDb = _db.HTMLLessons.Find(id);
            return View(htmlLessonFromDb);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            var htmlLessonFromDb = _db.HTMLLessons.Find(id);
            return View(htmlLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HTMLLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.HTMLLessons.Update(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            var htmlLessonFromDb = _db.HTMLLessons.Find(id);
            return View(htmlLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.HTMLLessons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.HTMLLessons.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
