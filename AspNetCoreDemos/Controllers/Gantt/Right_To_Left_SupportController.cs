﻿using AspNetCoreDemos.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GanttController : Controller
    {
        public ActionResult Right_To_Left_Support()
        {
            return View();
        }
    }
}