using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Scatter_ChartsController : Controller
    {
        public IActionResult Pan_And_Zoom()
        {
            return View(ChartDataRepository.SineInterval(-50, 50));
        }
    }
}