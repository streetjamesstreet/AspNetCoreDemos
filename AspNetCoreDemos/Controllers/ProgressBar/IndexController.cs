using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ProgressBarController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
