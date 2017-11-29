using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SortableController : Controller
    {
        public IActionResult Sortable_Panels()
        {
            return View();
        }
    }
}
