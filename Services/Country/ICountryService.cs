using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CountryService
{
	public interface ICountryService
	{
		Task<Domain.Country> GetByIdAsync(uint id);
		Task<IEnumerable<Domain.Country>> GetAllAsync();
		Task<IEnumerable<Domain.Country>> GetAllCountriesAboveTemperatureAsync(int temperature);
	}
}
