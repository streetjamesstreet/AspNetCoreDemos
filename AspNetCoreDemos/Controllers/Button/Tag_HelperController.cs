using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ButtonController : Controller
    {
        public IActionResult Tag_Helper()
        {
            return View();
        }
    }
}