using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Direction(String directionString)
        {
            if (string.IsNullOrEmpty(directionString))
            {
                ViewBag.Direction = "bottom";
            }
            else
            {
                ViewBag.Direction = directionString;
            }
            return View();
        }
    }
}
