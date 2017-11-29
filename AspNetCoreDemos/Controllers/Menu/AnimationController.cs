﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Animation(string animation, bool? opacity, int? delay)
        {
            ViewBag.animation = animation ?? "toggle";
            ViewBag.opacity = opacity ?? true;
            ViewBag.delay = delay ?? 100;
            return View();
        }
    }
}
