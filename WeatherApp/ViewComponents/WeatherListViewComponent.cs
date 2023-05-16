using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.ViewComponents
{
    public class WeatherListViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<CityWeather> model)
        {
            return View(model);
        }
    }
}
