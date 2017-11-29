using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreDemos.Controllers
{
    public partial class Funnel_ChartsController : Controller
    {
        public IActionResult Remote_Data_Binding()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult SpainElectricityProduction()
        {
            return Json(ChartDataRepository.SpainElectricityProduction());
        }
    }
}