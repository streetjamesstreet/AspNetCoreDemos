using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class DatePickerController : Controller
    {
        public ActionResult Tag_Helper()
        {
            return View();
        }
    }
}