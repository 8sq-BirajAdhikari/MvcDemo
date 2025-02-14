using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;
using System.Diagnostics;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(weeklyForecastList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static List<Weather> weeklyForecastList = new()
        {
            new Weather { Day = "Monday", Condition = "Sunny", TemperatureCelsius = 25 },
            new Weather { Day = "Tuesday", Condition = "Partly Cloudy", TemperatureCelsius = 22 },
            new Weather { Day = "Wednesday", Condition = "Rainy", TemperatureCelsius = 18 },
            new Weather { Day = "Thursday", Condition = "Thunderstorms", TemperatureCelsius = 20 },
            new Weather { Day = "Friday", Condition = "Windy", TemperatureCelsius = 19 },
            new Weather { Day = "Saturday", Condition = "Overcast", TemperatureCelsius = 21 },
            new Weather { Day = "Sunday", Condition = "Sunny", TemperatureCelsius = 26 }
        };
    }
}
