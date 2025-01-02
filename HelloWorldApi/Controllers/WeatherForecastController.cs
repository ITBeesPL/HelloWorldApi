using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        [Produces<List<WeatherForecastVm>>]
        public IEnumerable<WeatherForecastVm> Get(int id, string searchSummary, Guid countryGuid)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastVm
            {
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [Produces<List<WeatherForecastVm>>]
        public IActionResult Post([FromBody] WeatherForecastIm weatherForecastIm)
        {
            return Ok(new WeatherForecastVm());
        }

        [HttpPut]
        [Produces<List<WeatherForecastVm>>]
        public IActionResult Put([FromBody] WeatherForecastUm weatherForecastUm)
        {
            return Ok(new WeatherForecastVm()
            {
                Date = DateTime.Now,
                Summary = weatherForecastUm.Summary,
                TemperatureC = weatherForecastUm.TemperatureC
            });
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] WeatherForecastDm weatherForecastDm)
        {
            return Ok();
        }
    }
}
