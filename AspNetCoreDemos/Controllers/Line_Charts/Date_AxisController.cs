﻿

using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Line_ChartsController : Controller
    {
        public IActionResult Date_Axis()
        {
            return View(ChartDataRepository.DatePoints());
        }
    }
}