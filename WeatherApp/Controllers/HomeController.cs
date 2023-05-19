using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.Models;
using System.Linq;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _cityService;

        public HomeController(IWeatherService cityService)
        {
            _cityService = cityService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeatherList = _cityService.GetWeatherDetails();
            return View(cityWeatherList);
        }

        [Route("weather/{cityCode}")]
        public IActionResult Weather(string cityCode)
        {
            CityWeather cityWeather = _cityService.GetWeatherByCityCode(cityCode);
            if (cityWeather == null)
                return NotFound($"City with code '{cityCode}' is not found");
            return View(cityWeather);
        }
    }
}
