using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MaskedTextBoxController : Controller
    {
        public IActionResult Validation()
        {
            return View();
        }
    }
}