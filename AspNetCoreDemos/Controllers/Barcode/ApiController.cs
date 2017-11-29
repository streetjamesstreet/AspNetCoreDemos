using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class BarcodeController : Controller
    {
        public IActionResult Api()
        {
            return View();
        }
    }
}
