using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public IActionResult ServerFiltering()
        {
            return View();
        }
    }
}