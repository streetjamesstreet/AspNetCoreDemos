using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class SchedulerController
    {
        public IActionResult SignalR()
        {
            return View();
        }
    }
}
