using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class NotificationController : Controller
    {
        public ActionResult Events()
        {
            return View();
        }
    }
}