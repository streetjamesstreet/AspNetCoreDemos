﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class EditorController : Controller
    {
        public IActionResult Styles()
        {
            return View();
        }
    }
}