using AspNetCoreDemos.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspNetCoreDemos.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult Validation()
        {
            return View();
        }
    }
}