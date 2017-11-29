using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class DropDownListController : Controller
    {
        public ActionResult Custom_DataSource()
        {
            return View();
        }
    }
}