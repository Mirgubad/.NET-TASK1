﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
