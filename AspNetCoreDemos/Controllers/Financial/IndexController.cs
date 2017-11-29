
using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class FinancialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _BoeingStockData()
        {
            var db = new SampleEntitiesDataContext();

            return Json(
                from s in db.Stocks
                where s.Symbol == "BA"
                select new StockDataPoint
                {
                    Date = s.Date,
                    Open = s.Open,
                    High = s.High,
                    Low = s.Low,
                    Close = s.Close,
                    Volume = s.Volume
                }
            );
        }
    }
}