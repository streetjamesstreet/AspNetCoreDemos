using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Pie_ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}