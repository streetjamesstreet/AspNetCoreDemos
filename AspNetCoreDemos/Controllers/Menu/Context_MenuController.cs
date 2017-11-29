using Microsoft.AspNetCore.Mvc;
using AspNetCoreDemos.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public IActionResult Context_Menu()
        {
            return View();
        }

        public ActionResult _WebMailData([DataSourceRequest] DataSourceRequest request)
        {
            return Json(WebMailDataRepository.WebMailData().ToDataSourceResult(request));
        }
    }
}
