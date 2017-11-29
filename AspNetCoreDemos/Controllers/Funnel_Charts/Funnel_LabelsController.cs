using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Funnel_ChartsController : Controller
    {
        public IActionResult Funnel_Labels()
        {
            return View();
        }
    }
}