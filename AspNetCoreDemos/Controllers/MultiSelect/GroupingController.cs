using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using AspNetCoreDemos.Models;
using System.Linq;
using Kendo.Mvc.UI;

namespace AspNetCoreDemos.Controllers
{
    public partial class MultiSelectController : Controller
    {
        public ActionResult Grouping()
        {
            return View();
        }

        public ActionResult Customers_Read()
        {
            return Json(GetCustomers());
        }

        private static IEnumerable<CustomerViewModel> GetCustomers()
        {
            var northwind = new SampleEntitiesDataContext();
            return northwind.Customers.Select(customer => new CustomerViewModel
            {
                CustomerID = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Country = customer.Country,
                Phone = customer.Phone,
                Fax = customer.Fax,
                Bool = customer.Bool
            });
        }
    }
}