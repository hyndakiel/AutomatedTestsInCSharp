using Country;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedTestsInCSharp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CountryController : ControllerBase
	{
		private readonly ILogger<CountryController> logger;
		private readonly ICountryService countryService;

		public CountryController(ILogger<CountryController> logger, ICountryService countryService)
		{
			this.logger = logger;
			this.countryService = countryService;
		}

		[HttpGet("GetAll")]
		public async Task<IEnumerable<Domain.Country>> GetAll()
		{
			var ret = await this.countryService.GetAllAsync();

			return ret;
		}

		[HttpGet("GetAllCountriesAboveTemperature")]
		public async Task<IEnumerable<Domain.Country>> GetAllCountriesAboveTemperature(int temperature)
		{
			var ret = await this.countryService.GetAllCountriesAboveTemperatureAsync(temperature);

			return ret;
		}

		[HttpGet("GetById")]
		public async Task<Domain.Country> GetById(uint id)
		{
			var ret = await this.countryService.GetByIdAsync(id);

			return ret;
		}

		[HttpGet("GetById")]
		public async Task<Domain.Country> GetByName(string name)
		{
			var ret = await this.countryService.GetByNameAsync(name);

			return ret;
		}
	}
}
