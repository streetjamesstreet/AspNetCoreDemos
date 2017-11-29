using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Polar_ChartsController : Controller
    {
        public IActionResult Smooth_Polar_Line()
        {
            return View(ChartDataRepository.SunPosition());
        }
    }
}