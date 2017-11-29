using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Line_ChartsController : Controller
    {
        public IActionResult Stacked_Line()
        {
            return View();
        }
    }
}