using Kendo.Mvc.Extensions;
using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace AspNetCoreDemos.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public IActionResult Grouping()
        {
            return View();
        }

        public IList<CustomerViewModel> Customers_Read(string text)
        {
            return GetCustomers().Where(c => c.ContactName.Contains(text)).ToList();
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