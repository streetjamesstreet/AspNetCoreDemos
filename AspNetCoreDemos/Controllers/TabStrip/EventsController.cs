using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TabStripController : Controller
    {
        public ActionResult Events()
        {
            return View();
        }
    }
}