using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class DropDownListController : Controller
    {
        public ActionResult ServerFiltering()
        {
            return View();
        }
    }
}