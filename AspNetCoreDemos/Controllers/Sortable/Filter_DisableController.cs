﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SortableController : Controller
    {
        public IActionResult Filter_Disable()
        {
            return View();
        }
    }
}
