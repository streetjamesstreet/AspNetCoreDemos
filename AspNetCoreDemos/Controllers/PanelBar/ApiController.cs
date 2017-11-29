using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class PanelBarController : Controller
    {
        public ActionResult Api()
        {
            return View();
        }
    }
}