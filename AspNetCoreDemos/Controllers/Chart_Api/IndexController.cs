﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Chart_ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}