using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Api()
        {
            return View();
        }
    }
}
