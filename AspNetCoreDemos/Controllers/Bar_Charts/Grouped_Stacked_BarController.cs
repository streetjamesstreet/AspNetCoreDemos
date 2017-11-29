using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Bar_ChartsController : Controller
    {
        public IActionResult Grouped_Stacked_Bar()
        {
            return View();
        }
    }
}