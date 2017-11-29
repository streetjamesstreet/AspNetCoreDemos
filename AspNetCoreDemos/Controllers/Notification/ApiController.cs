using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class NotificationController : Controller
    {
        public ActionResult Api()
        {
            return View();
        }
    }
}