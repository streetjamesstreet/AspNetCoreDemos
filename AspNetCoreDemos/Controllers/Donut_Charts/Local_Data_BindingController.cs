﻿using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Donut_ChartsController : Controller
    {
        public IActionResult Local_Data_Binding()
        {
            return View(ChartDataRepository.SpainElectricityBreakdown());
        }
    }
}