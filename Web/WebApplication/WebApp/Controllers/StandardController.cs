using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StandardController : Controller
    {
        private readonly ApplicationDbContext db;

        public StandardController(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var data = db.Standards.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Standards model)
        {
            if (ModelState.IsValid)
            {
                //save to db
                db.Standards.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existing = db.Standards.Find(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Edit(Standards model)
        {
            if (ModelState.IsValid)
            {
                //save to db
                db.Standards.Update(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var existing = db.Standards.Find(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Delete(Standards model)
        {
            var existing = db.Standards.Find(model.Id);
            //save to db
            db.Standards.Remove(existing);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var existing = db.Standards.Find(id);
            return View(existing);
        }
    }
}