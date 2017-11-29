using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using AspNetCoreDemos.Models;

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace AspNetCoreDemos.Controllers
{

    public partial class AutoCompleteController : Controller
    {
        public IActionResult Virtualization()
        {
            return View();
        }

        public DataSourceResult Virtualization_Read([DataSourceRequest] DataSourceRequest request)
        {
            return GetOrders().ToDataSourceResult(request);
        }

        private static IEnumerable<OrderViewModel> GetOrders()
        {
            var northwind = new SampleEntitiesDataContext();

            return northwind.Orders.Select(order => new OrderViewModel
            {
                ContactName = order.Customer.ContactName,
                Freight = order.Freight,
                OrderDate = order.OrderDate,
                ShippedDate = order.ShippedDate,
                OrderID = order.OrderID,
                ShipAddress = order.ShipAddress,
                ShipCountry = order.ShipCountry,
                ShipName = order.ShipName,
                ShipCity = order.ShipCity,
                EmployeeID = order.EmployeeID,
                CustomerID = order.CustomerID
            });
        }
    }
}