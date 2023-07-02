namespace Repositories.Country
{
	public interface ICountryRepository
	{
		Task<Domain.Country> GetByIdAsync(uint id);
		Task<Domain.Country> GetByNameAsync(string name);
		Task<IEnumerable<Domain.Country>> GetAllAsync();
		Task<IEnumerable<Domain.Country>> GetAllCountriesAboveTemperatureAsync(int temperature);
	}
}
