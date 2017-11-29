using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TreeListController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}