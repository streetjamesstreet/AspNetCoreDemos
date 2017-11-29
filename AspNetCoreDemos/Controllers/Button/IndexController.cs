using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}