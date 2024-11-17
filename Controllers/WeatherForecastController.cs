using ApiFullSwaggerDocumintation.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ApiFullSwaggerDocumintation.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{


    private static readonly List<WeatherForecast> _weatherForecasts = [];
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        // Initialize with default values if the list is empty
        if (!_weatherForecasts.Any())
        {
            _weatherForecasts.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = EnumExtensions.GetRandom<WeatherSummary>()
            }));
    }
    }

    /// <summary>
    /// Retrieves the weather forecast list.
    /// </summary>
    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        return Ok(_weatherForecasts);
    }

    /// <summary>
    /// Updates a specific weather forecast by index.
    /// </summary>
    /// <param name="index">The index of the forecast to update.</param>
    /// <param name="forecast">The updated weather forecast.</param>
    [HttpPut("{index}")]
    public IActionResult UpdateWeatherForecast(
        int index, 
        [FromBody] WeatherForecast forecast)
    {
        if (!IsValidIndex(index))
            return BadRequest(BadRequestResponse.InvalidIndex);

        _weatherForecasts[index] = forecast;
        return Ok(_weatherForecasts[index]);
    }

    private static bool IsValidIndex(int index)
        {
        return index >= 0 && index < _weatherForecasts.Count;
    }
}
