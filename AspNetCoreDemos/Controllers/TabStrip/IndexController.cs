using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TabStripController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}