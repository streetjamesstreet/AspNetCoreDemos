using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class QrcodeController : Controller
    {
        public IActionResult Api()
        {
            return View();
        }
    }
}
