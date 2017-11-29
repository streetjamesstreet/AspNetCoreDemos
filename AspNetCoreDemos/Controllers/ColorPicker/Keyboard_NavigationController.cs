using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ColorPickerController : Controller
	{
		public IActionResult Keyboard_Navigation()
		{
			return View();
		}
	}
}
