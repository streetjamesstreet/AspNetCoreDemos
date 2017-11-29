using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ProgressBarController : Controller
	{
		public IActionResult Api()
		{
			return View();
		}
	}
}
