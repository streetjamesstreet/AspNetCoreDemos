﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Chart_ApiController : Controller
    {
        public IActionResult Pdf_Export()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    }
}