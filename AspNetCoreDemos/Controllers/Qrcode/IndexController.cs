using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class QrcodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
