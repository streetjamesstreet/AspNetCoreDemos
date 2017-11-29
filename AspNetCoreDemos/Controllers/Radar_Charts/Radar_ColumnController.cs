using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class Radar_ChartsController : Controller
    {
        public IActionResult Radar_Column()
        {
            return View();
        }
    }
}