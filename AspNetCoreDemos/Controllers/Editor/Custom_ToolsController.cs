using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class EditorController : Controller
    {
        public IActionResult Custom_Tools()
        {
            return View();
        }
    }
}