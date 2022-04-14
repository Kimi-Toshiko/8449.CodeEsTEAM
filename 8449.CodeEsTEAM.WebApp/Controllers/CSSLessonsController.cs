using _8449.CodeEsTEAM.WebApp.DAL;
using _8449.CodeEsTEAM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8449.CodeEsTEAM.WebApp.Controllers
{
    public class CSSLessonsController : Controller
    {
        private readonly CodeEsTeamDBContext _db;

        public CSSLessonsController(CodeEsTeamDBContext db)
        {
            _db = db; ;
        }

        public IActionResult Index()
        {
            IEnumerable<CSSLesson> objCssLessonsList = _db.CSSLessons;
            return View(objCssLessonsList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CSSLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.CSSLessons.Add(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Details(int? id)
        {
            var cssLessonFromDb = _db.CSSLessons.Find(id);
            return View(cssLessonFromDb);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            var cssLessonFromDb = _db.CSSLessons.Find(id);
            return View(cssLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CSSLesson obj)
        {
            if (ModelState.IsValid)
            {
                _db.CSSLessons.Update(obj);
                _db.SaveChanges();
                return View();
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            var cssLessonFromDb = _db.CSSLessons.Find(id);
            return View(cssLessonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.CSSLessons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.CSSLessons.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
