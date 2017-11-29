using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Funnel_ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}