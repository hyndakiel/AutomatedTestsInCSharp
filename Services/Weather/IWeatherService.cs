using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.WeatherService
{
	public interface IWeatherService
	{
		Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync();
		Task<IEnumerable<WeatherForecast>> GetAllForecastsBySummaryAsync(string summary);
		Task<IEnumerable<WeatherForecast>> GetAllForecastsForTomorrowAsync();
	}
}
