using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.UI;
using AspNetCoreDemos.Models;

namespace AspNetCoreDemos.Controllers
{
    public partial class TreeViewController : Controller
    {
        public ActionResult Templates()
        {
            return View();
        }

        public ActionResult Read_TemplateData(string id)
        {
            IEnumerable<TreeViewItemViewModel> result;
            if (string.IsNullOrEmpty(id))
            {
                result = TreeViewRepository.GetProjectData().Select(o => o.Clone());
            }
            else
            {
                result = TreeViewRepository.GetChildren(id);
            }
            return Json(result);
        }

    }
}
