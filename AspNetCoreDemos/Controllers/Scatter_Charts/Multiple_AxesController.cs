using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Scatter_ChartsController : Controller
    {
        public IActionResult Multiple_Axes()
        {
            return View(ChartDataRepository.EngineData());
        }
    }
}