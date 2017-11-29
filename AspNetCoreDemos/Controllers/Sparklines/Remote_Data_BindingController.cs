using System.Collections.Generic;
using AspNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class SparklinesController : Controller
    {
        public IActionResult Remote_Data_Binding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult _Weather(string station, int year, int month)
        {
            var db = new SampleEntitiesDataContext();
            var weatherData = db.Weather
                .Where(x => x.Station == station && x.Date.Year == year && x.Date.Month == month)
                .Select(x => new
                {
                    ID = x.ID,
                    Rain = x.Rain,             
                    TMax = x.TMax,
                    Wind = x.Wind
                });
            
            return Json(weatherData);
        }
    }
}