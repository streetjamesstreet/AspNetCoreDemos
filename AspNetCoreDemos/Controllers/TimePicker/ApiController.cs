using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TimePickerController : Controller
    {
        public ActionResult Api()
        {
            return View();
        }
    }
}