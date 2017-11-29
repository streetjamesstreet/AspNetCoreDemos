using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Scatter_ChartsController : Controller
    {
        public ActionResult Remote_Data_Binding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult _PricePerformanceData()
        {
            return Json(ChartDataRepository.PricePerformanceData());
        }
    }
}