using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult SignalR()
        {
            return View();
        }
    }
}
