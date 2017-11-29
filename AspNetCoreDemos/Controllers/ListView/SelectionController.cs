using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Selection()
        {
            return View(GetProducts());
        }        
    }
}