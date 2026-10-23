using System.Net.Http.Json;

namespace WorkingWithAppointments.Client;

public class WeatherForecastService(HttpClient Http)
{
    public async Task<WeatherForecast[]?> GetForecastAsync(DateTime startDate)
    {
        return await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
}
