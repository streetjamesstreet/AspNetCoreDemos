using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Orientation(string orientation)
        {
            MenuOrientation value = MenuOrientation.Horizontal;

            if (orientation == "vertical")
            {
                value = MenuOrientation.Vertical;
            }

            return View(value);
        }
    }
}
