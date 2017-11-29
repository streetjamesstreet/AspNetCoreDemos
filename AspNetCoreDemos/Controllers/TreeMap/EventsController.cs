using System;
using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Controllers
{
    public partial class TreeMapController : Controller
    {
        public ActionResult Events()
        {
            return View();
        }

        public ActionResult _PopulationUSA()
        {
            return Json(TreeMapDataRepository.PopulationUSAData());
        }
    }
}