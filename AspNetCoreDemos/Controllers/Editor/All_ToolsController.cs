using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class EditorController : Controller
    {
        public IActionResult All_Tools()
        {
            return View();
        }
    }
}