using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult ModelBinding()
        {
            var northwind = new SampleEntitiesDataContext();

            var categories = northwind.Categories.ToList();
            categories.ForEach(c => 
                               c.Products = northwind.Products
                                .Where(p => p.CategoryID == c.CategoryID)
                                .ToList());

            return View(northwind.Categories);
        }
    }
}
