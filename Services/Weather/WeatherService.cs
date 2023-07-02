using Domain;
using Repositories.Weather;

namespace Services.WeatherService
{
	internal class WeatherService : IWeatherService
	{
		private readonly IWeatherRepository weatherRepository;

		public WeatherService(IWeatherRepository weatherRepository)
		{
			this.weatherRepository = weatherRepository;
		}

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync()
		{
			return this.weatherRepository.GetAllForecastsAsync();
		}

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsBySummaryAsync(string summary)
		{
			return this.weatherRepository.GetAllForecastsBySummaryAsync(summary);
		}

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrowAsync()
		{
			return this.weatherRepository.GetAllForecastsForTomorrowAsync();
		}
	}
}
