using Swashbuckle.AspNetCore.Filters;

namespace ApiFullSwaggerDocumintation.OpenApi.Examples;
public class UpdateWeatherForecastResponseExample : IMultipleExamplesProvider<WeatherForecast>
{
    public IEnumerable<SwaggerExample<WeatherForecast>> GetExamples()
    {

        yield
            return SwaggerExample.Create(nameof(Freezing), Freezing);
        yield
            return SwaggerExample.Create(nameof(Mild), Mild);
        yield
            return SwaggerExample.Create(nameof(Warm), Warm);
    }

    private WeatherForecast Mild = new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now),
        TemperatureC = 25,
        Summary = WeatherSummary.Mild
    };

    private WeatherForecast Warm = new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now),
        TemperatureC = 29,
        Summary = WeatherSummary.Warm
    };

    private WeatherForecast Freezing = new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now),
        TemperatureC = -5,
        Summary = WeatherSummary.Freezing
    };
}
