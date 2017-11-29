using Microsoft.AspNetCore.Mvc;
using AspNetCoreDemos.Models;

namespace AspNetCoreDemos.Controllers
{
    public partial class Box_Plot_ChartsController : Controller
    {
        public IActionResult Remote_Data_Binding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult _OzoneConcentration()
        {
            return Json(ChartDataRepository.OzoneConcentrationRemote());
        }
    }
}