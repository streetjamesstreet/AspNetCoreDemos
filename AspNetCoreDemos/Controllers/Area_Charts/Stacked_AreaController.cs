using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Area_ChartsController : Controller
    {
        public IActionResult Stacked_Area()
        {
            return View();
        }
    }
}