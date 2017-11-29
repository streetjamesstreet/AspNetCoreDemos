using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class FinancialController : Controller
    {
        public IActionResult Panes()
        {
            return View();
        }
    }
}