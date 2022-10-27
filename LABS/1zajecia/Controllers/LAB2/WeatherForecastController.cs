using Microsoft.AspNetCore.Mvc;
using _1zajecia.Services.LAB2;

namespace _1zajecia.Controllers.LAB2
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")] //mapowanie nazwy 
        public IEnumerable<WeatherForecast> Get()
        {
            var Calculate = new Calculate(24);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        public int GetValue()
        {
            var calculateInstance = new Calculate(24);
            calculateInstance.Increase(10);
            calculateInstance.Decrease(23);
            return calculateInstance.GetValue();
        }

        [HttpGet]
        public List<int> GetValueList()
        {
            var calculateInstance = new Calculate(24);
            var calculateInstance2 = new Calculate(50);
            return new List<int>() { calculateInstance2.GetValue(), calculateInstance.GetValue() };
        }
    }
}
