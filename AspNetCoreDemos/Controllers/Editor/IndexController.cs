using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class EditorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImageBrowser()
        {
            return View();
        }
    }
}