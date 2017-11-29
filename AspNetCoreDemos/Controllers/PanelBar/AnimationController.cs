﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class PanelBarController : Controller
    {
        public ActionResult Animation(string animation, bool? opacity)
        {
            ViewBag.animation = animation ?? "expand";
            ViewBag.opacity = opacity ?? true;

            return View();
        }
    }
}