﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}