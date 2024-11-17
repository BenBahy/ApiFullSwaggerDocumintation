using Swashbuckle.AspNetCore.Filters;

namespace ApiFullSwaggerDocumintation.OpenApi.Examples;

public class GetWeatherForecastResponseExample : IExamplesProvider<IEnumerable<WeatherForecast>>
{
    public IEnumerable<WeatherForecast> GetExamples()
    {
        return new List<WeatherForecast> {
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = 25,
                Summary = WeatherSummary.Mild
            },
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)),
                TemperatureC = 29,
                Summary = WeatherSummary.Warm
            }
        };
    }
}