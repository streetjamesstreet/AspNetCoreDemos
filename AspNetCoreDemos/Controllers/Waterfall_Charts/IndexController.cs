using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Waterfall_ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}