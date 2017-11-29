using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{ 

    public partial class ListViewController : Controller
    {
        public ActionResult Custom_DataSource()
        {
            return View();
        }
    }
}
