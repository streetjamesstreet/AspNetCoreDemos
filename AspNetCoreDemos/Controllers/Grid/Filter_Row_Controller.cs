using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class GridController : Controller
    {
        public ActionResult Filter_Row()
        {
            ViewData["initial"] = productService.Read();
            return View();
        }
    }
}