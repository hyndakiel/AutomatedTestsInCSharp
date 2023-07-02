using Domain;

namespace Weather
{
	public interface IWeatherService
	{
		Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync();
		Task<IEnumerable<WeatherForecast>> GetAllForecastsBySummaryAsync(string summary);
		Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrowAsync();
	}
}
