using Microsoft.Extensions.DependencyInjection;

namespace Weather
{
	public static class ServicesCollectionExtensions
	{
		public static void AddWeatherServices(this IServiceCollection services)
		{
			services.AddTransient<IWeatherService, WeatherService>();
		}
	}
}
