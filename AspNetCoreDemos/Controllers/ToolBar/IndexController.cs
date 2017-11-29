using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ToolBarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
