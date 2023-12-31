using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Cocona;
using CreatingCliTools.Weather;

namespace CLI
{
    public class WeatherCommands
    {
        private readonly IWeatherService _weatherService;

        public WeatherCommands(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Command("weather")]
        public async Task Weather1(string city)
        {
            var weather = await _weatherService.GetWeatherForCityAsync(city);
            Console.WriteLine(JsonSerializer.Serialize(weather, new JsonSerializerOptions { WriteIndented = true }));
        }

        [Ignore]
        public async Task Weather2(string city)
        {
            var weather = await _weatherService.GetWeatherForCityAsync(city);
            Console.WriteLine(JsonSerializer.Serialize(weather, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}