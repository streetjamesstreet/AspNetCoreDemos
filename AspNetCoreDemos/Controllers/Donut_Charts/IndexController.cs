using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Donut_ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}