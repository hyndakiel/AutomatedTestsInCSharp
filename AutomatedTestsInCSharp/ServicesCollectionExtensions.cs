using Country;
using Repositories;
using Weather;

namespace AutomatedTestsInCSharp
{
	public static class ServicesCollectionExtensions
	{
		public static void AddServices(this IServiceCollection services)
		{
			services.AddRepositoryServices();
			services.AddCountryServices();
			services.AddWeatherServices();
		}
	}
}
