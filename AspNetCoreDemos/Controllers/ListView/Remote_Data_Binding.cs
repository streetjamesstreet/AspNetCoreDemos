using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Remote_Data_Binding()
        {
            return View(GetProducts());
        }
    }
}