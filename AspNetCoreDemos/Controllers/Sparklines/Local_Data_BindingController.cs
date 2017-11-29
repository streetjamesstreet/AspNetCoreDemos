using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SparklinesController : Controller
    {
        public IActionResult Local_Data_Binding()
        {
            return View(ChartDataRepository.CompensationData());
        }
    }
}