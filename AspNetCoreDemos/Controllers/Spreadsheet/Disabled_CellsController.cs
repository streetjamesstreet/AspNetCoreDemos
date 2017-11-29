using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult Disabled_Cells()
        {
            return View();
        }
    }
}