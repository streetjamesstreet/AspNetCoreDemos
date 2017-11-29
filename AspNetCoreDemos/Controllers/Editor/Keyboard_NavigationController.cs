using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class EditorController : Controller
    {
        public IActionResult Keyboard_Navigation()
        {
            return View();
        }
    }
}