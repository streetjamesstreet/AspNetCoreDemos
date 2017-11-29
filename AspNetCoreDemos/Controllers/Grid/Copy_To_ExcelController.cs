using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class GridController : Controller
    {        
        public ActionResult Copy_To_Excel()
        {
            return View();
        }
    }
}