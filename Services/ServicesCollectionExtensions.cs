using Microsoft.Extensions.DependencyInjection;
using Services.CountryService;
using Services.WeatherService;

namespace Services
{
	public static class ServicesCollectionExtensions
	{
		public static void AddServices(this IServiceCollection services)
		{
			services.AddTransient<ICountryService, Services.CountryService.CountryService>();
			services.AddTransient<IWeatherService, Services.WeatherService.WeatherService>();
		}
	}
}
