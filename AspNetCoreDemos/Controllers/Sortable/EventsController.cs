﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SortableController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}
