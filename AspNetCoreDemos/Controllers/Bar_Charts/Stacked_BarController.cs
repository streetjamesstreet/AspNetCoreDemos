using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Bar_ChartsController : Controller
    {
        public IActionResult Stacked_Bar()
        {
            return View();
        }
    }
}