using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class CalendarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}