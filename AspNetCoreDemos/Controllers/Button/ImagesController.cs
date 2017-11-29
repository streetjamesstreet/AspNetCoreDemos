using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ButtonController : Controller
	{
		public IActionResult Images()
		{
			return View();
		}
	}
}