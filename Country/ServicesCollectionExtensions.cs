using Microsoft.Extensions.DependencyInjection;

namespace Country
{
	public static class ServicesCollectionExtensions
	{
		public static void AddCountryServices(this IServiceCollection services)
		{
			services.AddTransient<ICountryService, CountryService>();
		}
	}
}
