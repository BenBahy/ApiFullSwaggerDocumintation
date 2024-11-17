using Swashbuckle.AspNetCore.Annotations;

namespace ApiFullSwaggerDocumintation;

/// <summary>
/// Represents a weather forecast with detailed properties.
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// Forecast Date.
    /// </summary>
    [SwaggerSchema("The date of the forecast.")]
    public DateOnly Date { get; set; }

    /// <summary>
    /// Temperature in Celsius.
    /// </summary>
    [SwaggerSchema("The temperature in Celsius.")]
    public int TemperatureC { get; set; }

    /// <summary>
    /// Temperature in Fahrenheit.
    /// </summary>
    [SwaggerSchema("The temperature in Fahrenheit.")]
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// Weather summary from the predefined options.
    /// </summary>
    [SwaggerSchema("The summary of the weather condition.")]
    public WeatherSummary? Summary { get; set; }
}
