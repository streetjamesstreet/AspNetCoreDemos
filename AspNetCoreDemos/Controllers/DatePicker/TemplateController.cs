﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class DatePickerController : Controller
    {
        public ActionResult Template()
        {
            return View();
        }
    }
}