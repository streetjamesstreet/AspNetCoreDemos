﻿using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class MultiSelectController : Controller
    {
        public ActionResult ClientFiltering()
        {
            return View();
        }
    }
}