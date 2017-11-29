using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SchedulerController
    {
        public IActionResult Pdf_Export()
        {
            return View();
        }
    }
}
