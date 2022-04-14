using _8449.CodeEsTEAM.WebApp.DAL;
using _8449.CodeEsTEAM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8449.CodeEsTEAM.WebApp.Controllers
{
    public class JSLessonsController : Controller
    {
        private readonly CodeEsTeamDBContext _db;

        public JSLessonsController(CodeEsTeamDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<JSLesson> objJsLessonsList = _db.JSLessons;
            return View(objJsLessonsList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JSLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.JSLessons.Add(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Details(int? id)
        {
            var jsLessonFromDb = _db.JSLessons.Find(id);
            return View(jsLessonFromDb);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            var jsLessonFromDb = _db.JSLessons.Find(id);
            return View(jsLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JSLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.JSLessons.Add(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            var jsLessonFromDb = _db.JSLessons.Find(id);
            return View(jsLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.JSLessons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.JSLessons.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
