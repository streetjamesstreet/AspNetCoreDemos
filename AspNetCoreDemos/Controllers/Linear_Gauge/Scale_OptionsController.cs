using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Linear_GaugeController : Controller
    {
        public IActionResult Scale_Options()
        {
            return View();
        }
    }
}
