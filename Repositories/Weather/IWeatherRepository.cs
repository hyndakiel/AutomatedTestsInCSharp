using Domain;

namespace Repositories.Weather
{
	public interface IWeatherRepository
	{
		Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync();
		Task<IEnumerable<WeatherForecast>> GetAllForecastsBySummaryAsync(string summary);
		Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrowAsync();
	}
}
