﻿using AspNetCoreDemos.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GanttController : Controller
    {
        public ActionResult Keyboard_Navigation()
        {
            return View();
        }
    }
}