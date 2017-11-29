using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Radar_ChartsController : Controller
    {
        public IActionResult Grouped_Data()
        {
            return View();
        }

        [HttpPost]
        public IActionResult _WindData()
        {
            return Json(ChartDataRepository.WindData());
        }
    }
}