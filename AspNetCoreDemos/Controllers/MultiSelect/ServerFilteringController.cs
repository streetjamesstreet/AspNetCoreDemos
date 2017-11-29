using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MultiSelectController : Controller
    {
        public ActionResult ServerFiltering()
        {
            return View();
        }
    }
}