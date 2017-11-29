﻿using System.Collections.Generic;
using System.Linq;
using AspNetCoreDemos.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ListViewController : Controller
    {
        private ProductService productService;

        public ListViewController()
        {
            productService = new ProductService(new SampleEntitiesDataContext());
        }

        protected override void Dispose(bool disposing)
        {
            productService.Dispose();

            base.Dispose(disposing);
        }

        public ActionResult Index()
        {
            return View(GetProducts());
        }
                                      
        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetProducts().ToDataSourceResult(request));
        }

        private static IEnumerable<ProductViewModel> GetProducts()
        {
            var northwind = new SampleEntitiesDataContext();

            return northwind.Products.Select(product => new ProductViewModel
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice.HasValue ? product.UnitPrice.Value : default(decimal),
                UnitsInStock = product.UnitsInStock.HasValue ? product.UnitsInStock.Value : default(int),
                UnitsOnOrder = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : default(int),
                Discontinued = product.Discontinued,
                LastSupply = DateTime.Today
            });
        }
    }
}