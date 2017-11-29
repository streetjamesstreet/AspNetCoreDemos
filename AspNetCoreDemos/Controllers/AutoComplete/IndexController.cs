using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}