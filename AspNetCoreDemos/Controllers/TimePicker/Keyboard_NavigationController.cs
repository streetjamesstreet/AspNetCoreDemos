using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TimePickerController : Controller
    {
        public ActionResult Keyboard_Navigation()
        {
            return View();
        }
    }
}