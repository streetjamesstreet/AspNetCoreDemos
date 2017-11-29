using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TimePickerController : Controller
    {
        public ActionResult RangeSelection()
        {
            return View();
        }
    }
}