﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class WindowController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}