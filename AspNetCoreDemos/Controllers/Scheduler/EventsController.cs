﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SchedulerController
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}
