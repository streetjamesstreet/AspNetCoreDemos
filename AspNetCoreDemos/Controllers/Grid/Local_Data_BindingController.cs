﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GridController : Controller
    {        
        public ActionResult Local_Data_Binding()
        {
            var model = productService.Read();

            return View(model);
        }        
    }
}