using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public IActionResult Keyboard_Navigation()
        {
            return View();
        }
    }
}