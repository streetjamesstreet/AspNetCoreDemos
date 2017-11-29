using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Funnel_ChartsController : Controller
    {
        public IActionResult Local_Data_Binding()
        {
            ViewData["before"] = ChartDataRepository.BeforeOptimizationData();
            ViewData["after"] = ChartDataRepository.AfterOptimizationData();
            return View();
        }
    }
}