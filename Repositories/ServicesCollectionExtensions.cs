using Microsoft.Extensions.DependencyInjection;
using Repositories.Country;
using Repositories.Weather;

namespace Repositories
{
	public static class ServicesCollectionExtensions
	{
		public static void AddRepositoryServices(this IServiceCollection services)
		{
			services.AddTransient<ICountryRepository, CountryRepository>();
			services.AddTransient<IWeatherRepository, WeatherRepository>();
		}
	}
}
