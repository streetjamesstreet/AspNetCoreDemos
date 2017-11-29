using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
	public partial class UploadController : Controller
	{
		public ActionResult Templates()
		{
			return View();
		}
	}
}
