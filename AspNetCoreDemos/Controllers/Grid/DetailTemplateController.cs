using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GridController : Controller
    {        
        public ActionResult DetailTemplate()
        {
            return View();
        }
    }
}