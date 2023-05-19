using ServiceContracts;
using ServiceContracts.Models;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private List<CityWeather> _cityWeatherList;

        public WeatherService() 
        {
            _cityWeatherList = new List<CityWeather>() {
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
        }
        public List<CityWeather> GetWeatherDetails()
        {
            return _cityWeatherList;
        }

        public CityWeather GetWeatherByCityCode(string cityCode)
        {
            return _cityWeatherList.FirstOrDefault(c => c.CityUniqueCode == cityCode)!;
        }
    }
}