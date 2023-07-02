using Domain;
using Microsoft.AspNetCore.Mvc;
using Weather;

namespace AutomatedTestsInCSharp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> logger;
		private readonly IWeatherService weatherService;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
		{
			this.logger = logger;
			this.weatherService = weatherService;
		}

		[HttpGet("GetAllForecasts")]
		public async Task<IEnumerable<WeatherForecast>> GetAllForecasts()
		{
			var ret = await this.weatherService.GetAllForecastsAsync();

			return ret;
		}

		[HttpGet("GetAllForecastsBySummary")]
		public async Task<IEnumerable<WeatherForecast>>GetAllForecastsBySummary(string summary)
		{
			var ret = await this.weatherService.GetAllForecastsBySummaryAsync(summary);

			return ret;
		}

		[HttpGet("GetAllForecastsForTomorrow")]
		public async Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrow()
		{
			var ret = await this.weatherService.GetAllForecastsForTomorrowAsync();

			return ret;
		}
	}
}