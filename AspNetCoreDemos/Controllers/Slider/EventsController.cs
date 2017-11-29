using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SliderController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}