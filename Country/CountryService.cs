using Repositories.Country;

namespace Country
{
	public class CountryService : ICountryService
	{
		private readonly ICountryRepository countryRepository;

		public CountryService(ICountryRepository countryRepository) 
		{
			this.countryRepository = countryRepository;
		}

		public Task<IEnumerable<Domain.Country>> GetAllAsync()
		{
			return this.countryRepository.GetAllAsync();
		}

		public Task<IEnumerable<Domain.Country>> GetAllCountriesAboveTemperatureAsync(int temperature)
		{
			return this.countryRepository.GetAllCountriesAboveTemperatureAsync(temperature);
		}

		public Task<Domain.Country> GetByIdAsync(uint id)
		{
			return this.countryRepository.GetByIdAsync(id);
		}

		public Task<Domain.Country> GetByNameAsync(string name)
		{
			var nameToUse = name.Trim();

			return this.countryRepository.GetByNameAsync(nameToUse);
		}
	}
}
