﻿using System.Collections.Generic; 
using AspNetCoreDemos.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Editing()
        {
            return View(productService.Read());
        }

        public ActionResult Editing_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs("Post")]

        public ActionResult Editing_Create([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            var results = new List<ProductViewModel>();

            if (product != null && ModelState.IsValid)
            {                
                productService.Create(product);
                results.Add(product);                
            }

            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs("Post")]
        public ActionResult Editing_Update([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Update(product);
            }

            return Json(ModelState.ToDataSourceResult());
        }

        [AcceptVerbs("Post")]
        public ActionResult Editing_Destroy([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null)
            {
                productService.Destroy(product);                
            }

            return Json(ModelState.ToDataSourceResult());
        }                          
    }
}