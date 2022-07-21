using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StandardController : Controller
    {
        private readonly ApplicationDbContext db;

        public StandardController(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

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
    }
}