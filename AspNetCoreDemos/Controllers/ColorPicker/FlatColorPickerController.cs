using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class ColorPickerController : Controller
	{
		public IActionResult FlatColorPicker()
		{
			return View();
		}
	}
}
