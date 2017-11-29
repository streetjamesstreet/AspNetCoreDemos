using AspNetCoreDemos.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class GanttController : Controller
    {
        public ActionResult ServerBinding()
        {
            ViewBag.Tasks = taskService.GetAll();
            ViewBag.Dependencies = dependencyService.GetAll();

            return View();
        }
    }
}