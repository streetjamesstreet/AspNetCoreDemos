﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TreeViewController : Controller
    {
        public ActionResult Api()
        {
            return View();
        }
    }
}
