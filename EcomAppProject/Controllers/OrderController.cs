﻿using Microsoft.AspNetCore.Mvc;

namespace EcomAppProject.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
