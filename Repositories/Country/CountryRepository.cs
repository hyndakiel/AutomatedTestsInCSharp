namespace Repositories.Country
{
    public class CountryRepository : ICountryRepository
	{
		internal static readonly IEnumerable<Domain.Country> CountriesInDb = new List<Domain.Country>()
		{
			new Domain.Country()
			{
				Id = 1,
				Name = "Brasil",
				WeatherForecasts = new List<Domain.WeatherForecast>
				{
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 1),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 2),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 3),
				},
			},
			new Domain.Country()
			{
				Id = 2,
				Name = "Portugal",
				WeatherForecasts = new List<Domain.WeatherForecast>
				{
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 4),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 5),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 6),
				},
			},
			new Domain.Country()
			{
				Id = 3,
				Name = "Finland",
				WeatherForecasts = new List<Domain.WeatherForecast>
				{
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 7),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 8),
					WeatherRepository.WeatherForecastsInDb.FirstOrDefault(w => w.Id == 9),
				},
			}
		};

		public Task<IEnumerable<Domain.Country>> GetAllAsync()
		{
			return Task.FromResult(CountriesInDb);
		}

		public Task<IEnumerable<Domain.Country>> GetAllCountriesAboveTemperatureAsync(int temperature)
		{
			return Task.FromResult(CountriesInDb.Where(c => c.WeatherForecastToday.TemperatureC > temperature));
		}

		public Task<Domain.Country> GetByIdAsync(uint id)
		{
			return Task.FromResult(CountriesInDb.FirstOrDefault(c => c.Id == id));
		}

		public Task<Domain.Country> GetByNameAsync(string name)
		{
			return Task.FromResult(CountriesInDb.FirstOrDefault(c => c.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)));
		}
	}
}
