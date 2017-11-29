using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Polar_ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}