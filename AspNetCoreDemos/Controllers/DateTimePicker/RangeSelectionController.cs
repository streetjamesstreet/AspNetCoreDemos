using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class DateTimePickerController : Controller
    {
        public ActionResult RangeSelection()
        {
            return View();
        }
    }
}