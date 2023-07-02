using Domain;
using Repositories.Weather;

namespace Repositories
{
	public class WeatherRepository : IWeatherRepository
	{
		public static readonly IEnumerable<Domain.WeatherForecast> WeatherForecastsInDb = new List<Domain.WeatherForecast>()
		{
			new Domain.WeatherForecast()
			{
				Id = 1,
				Date = DateTime.Today,
				TemperatureC = 30,
				Summary = "Sunny",
			},
			new Domain.WeatherForecast()
			{
				Id = 2,
				Date = DateTime.Today.AddDays(1),
				TemperatureC = 32,
				Summary = "Sunny",
			},
			new Domain.WeatherForecast()
			{
				Id = 3,
				Date = DateTime.Today.AddDays(2),
				TemperatureC = 35,
				Summary = "Sunny",
			},
			new Domain.WeatherForecast()
			{
				Id = 4,
				Date = DateTime.Today,
				TemperatureC = 23,
				Summary = "Warm",
			},
			new Domain.WeatherForecast()
			{
				Id = 5,
				Date = DateTime.Today.AddDays(1),
				TemperatureC = 22,
				Summary = "Warm",
			},
			new Domain.WeatherForecast()
			{
				Id = 6,
				Date = DateTime.Today.AddDays(2),
				TemperatureC = 21,
				Summary = "Mild",
			},
			new Domain.WeatherForecast()
			{
				Id = 7,
				Date = DateTime.Today,
				TemperatureC = 15,
				Summary = "Cool",
			},
			new Domain.WeatherForecast()
			{
				Id = 8,
				Date = DateTime.Today.AddDays(1),
				TemperatureC = 12,
				Summary = "Chilly",
			},
			new Domain.WeatherForecast()
			{
				Id = 9,
				Date = DateTime.Today.AddDays(2),
				TemperatureC = 10,
				Summary = "Chilly",
			},
		};

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync()
		{
			return Task.FromResult(WeatherForecastsInDb);
		}

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsBySummaryAsync(string summary)
		{
			return Task.FromResult(WeatherForecastsInDb.Where(w => summary.Equals(w.Summary)));
		}

		public Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrowAsync()
		{
			return Task.FromResult(WeatherForecastsInDb.Where(w => DateTime.Today.AddDays(1).Equals(w.Date.Date)));
		}
	}
}
