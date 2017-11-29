using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ButtonController : Controller
	{
		public IActionResult Keyboard_Navigation()
		{
			return View();
		}
	}
}