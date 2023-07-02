using Domain;
using Repositories.Country;

namespace Services.CountryService
{
	internal class CountryService : ICountryService
	{
		private readonly ICountryRepository countryRepository;

		public CountryService(ICountryRepository countryRepository) 
		{
			this.countryRepository = countryRepository;
		}

		public Task<IEnumerable<Country>> GetAllAsync()
		{
			return this.countryRepository.GetAllAsync();
		}

		public Task<IEnumerable<Country>> GetAllCountriesAboveTemperatureAsync(int temperature)
		{
			return this.countryRepository.GetAllCountriesAboveTemperatureAsync(temperature);
		}

		public Task<Country> GetByIdAsync(uint id)
		{
			return this.countryRepository.GetByIdAsync(id);
		}
	}
}
