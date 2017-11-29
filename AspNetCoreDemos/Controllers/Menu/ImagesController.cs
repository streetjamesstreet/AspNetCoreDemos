using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Images()
        {
            return View();
        }
    }
}
