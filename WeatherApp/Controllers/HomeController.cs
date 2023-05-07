using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        List<CityWeather> cityWeatherList = new List<CityWeather>() {
                new CityWeather() {
                    CityUniqueCode = "LDN",
                    CityName = "London",
                    DateAndTime = new DateTime(2030, 1, 1, 8, 0, 0),
                    TemperatureFahrenheit = 33
                },
                new CityWeather() {
                    CityUniqueCode = "NYC",
                    CityName = "New-York",
                    DateAndTime = new DateTime(2030, 1, 1, 3, 0, 0),
                    TemperatureFahrenheit = 60
                },
                new CityWeather() {
                    CityUniqueCode = "PAR",
                    CityName = "Paris",
                    DateAndTime = new DateTime(2030, 1, 1, 9, 0, 0),
                    TemperatureFahrenheit = 82
                }
            };


        [Route("/")]
        public IActionResult Index()
        {
            return View(cityWeatherList);
        }

        [Route("weather/{cityCode}")]
        public IActionResult Weather(string cityCode)
        {
            CityWeather cityWeather = cityWeatherList.FirstOrDefault(c => c.CityUniqueCode == cityCode);
            if (cityWeather == null)
                return NotFound($"City with code '{cityCode}' is not found");
            return View(cityWeather);
        }
    }
}
