using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class BarcodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
