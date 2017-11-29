﻿using Microsoft.AspNetCore.Mvc;
using AspNetCoreDemos.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace AspNetCoreDemos.Controllers
{
    public partial class DataSourceController : Controller
    {
        private ProductService productService;

        public DataSourceController()
        {
            productService = new ProductService(new SampleEntitiesDataContext());
        }

        protected override void Dispose(bool disposing)
        {
            productService.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Shared_Datasource()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }
    }
}