using ACD.School.Services;
using ACD.School.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ACD.School.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService studentService;

        public HomeController(
            ILogger<HomeController> logger,
            IStudentService studentService
            )
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateStudent(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = studentService.Create(model);
                if (res.Item1)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var res = studentService.Delete(id);
            if (res.Item1) return RedirectToAction("Index");

            return View("Error");
        }
    }
}