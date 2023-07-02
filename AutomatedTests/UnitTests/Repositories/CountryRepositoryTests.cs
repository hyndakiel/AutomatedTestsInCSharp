using FluentAssertions;
using Repositories;
using Repositories.Country;

namespace AutomatedTests.UnitTests.Repositories
{
	public sealed class CountryRepositoryTests
	{
		[Fact]
		public async Task GetAllAsync_Should_Return_All_Products()
		{
			var expectedResult = new List<Domain.Country>()
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

			var countryRepository = new CountryRepository();

			var result = await countryRepository.GetAllAsync();

			result.Should().BeEquivalentTo(expectedResult);
		}

		[Theory]
		[InlineData(14)]
		[InlineData(15)]
		[InlineData(33)]
		public async Task GetAllCountriesAboveTemperatureAsync_Should_Return_All_Countries_Above_Temperature(int temperature)
		{
			var expectedResult = GetExpectedResultForTemperatureTest(temperature);

			var countryRepository = new CountryRepository();

			var result = await countryRepository.GetAllCountriesAboveTemperatureAsync(temperature);

			result.Should().BeEquivalentTo(expectedResult);
		}

		[Theory]
		[MemberData(nameof(GetNames))]
		public async Task GetByNameAsync_Should_Return_Country_With_Name(string name)
		{
			var expectedResult = GetExpectedResultForNameTest(name);

			var countryRepository = new CountryRepository();

			var result = await countryRepository.GetByNameAsync(name);

			result.Name.Should().BeEquivalentTo(expectedResult.Name);
		}

		public static IEnumerable<object[]> GetNames()
		{
			yield return new object[] { "Finland" };
			yield return new object[] { "Brasil" };
		}

		private Domain.Country GetExpectedResultForNameTest(string name)
		{
			var expectedDict = new Dictionary<string, Domain.Country>()
			{
				{ "Finland", new Domain.Country() {Name = name} },
				{ "Brasil", new Domain.Country() {Name = name} },
			};

			expectedDict.TryGetValue(name, out var country);

			return country;
		}


		private List<Domain.Country> GetExpectedResultForTemperatureTest(int temperature)
		{
			var expectedDict = new Dictionary<int, List<Domain.Country>>()
			{
				{
					14, 
					new List<Domain.Country>() 
					{
						new Domain.Country()
						{
							Id = 1u,
							Name = "Brasil",
							WeatherForecasts = new List<Domain.WeatherForecast>()
							{
								new Domain.WeatherForecast
								{
									Id = 1u,
									Summary = "Sunny",
									TemperatureC = 30,
									Date = DateTime.Today,
								},
								new Domain.WeatherForecast
								{
									Id = 2u,
									Summary = "Sunny",
									TemperatureC = 32,
									Date = DateTime.Today.AddDays(1),
								},
								new Domain.WeatherForecast
								{
									Id = 3u,
									Summary = "Sunny",
									TemperatureC = 35,
									Date = DateTime.Today.AddDays(2),
								}
							},
						},
						new Domain.Country()
						{
							Id = 2u,
							Name = "Portugal",
							WeatherForecasts = new List<Domain.WeatherForecast>()
							{
								new Domain.WeatherForecast
								{
									Id = 4u,
									Summary = "Warm",
									TemperatureC = 23,
									Date = DateTime.Today,
								},
								new Domain.WeatherForecast
								{
									Id = 5u,
									Summary = "Warm",
									TemperatureC = 22,
									Date = DateTime.Today.AddDays(1),
								},
								new Domain.WeatherForecast
								{
									Id = 6u,
									Summary = "Mild",
									TemperatureC = 21,
									Date = DateTime.Today.AddDays(2),
								}
							},
						},
						new Domain.Country()
						{
							Id = 3u,
							Name = "Finland",
							WeatherForecasts = new List<Domain.WeatherForecast>()
							{
								new Domain.WeatherForecast
								{
									Id = 7u,
									Summary = "Cool",
									TemperatureC = 15,
									Date = DateTime.Today,
								},
								new Domain.WeatherForecast
								{
									Id = 8u,
									Summary = "Chilly",
									TemperatureC = 12,
									Date = DateTime.Today.AddDays(1),
								},
								new Domain.WeatherForecast
								{
									Id = 9u,
									Summary = "Chilly",
									TemperatureC = 10,
									Date = DateTime.Today.AddDays(2),
								}
							},
						},
					}
				},
				{
					15,
					new List<Domain.Country>()
					{
						new Domain.Country()
						{
							Id = 1u,
							Name = "Brasil",
							WeatherForecasts = new List<Domain.WeatherForecast>()
							{
								new Domain.WeatherForecast
								{
									Id = 1u, 
									Summary = "Sunny", 
									TemperatureC = 30,
									Date = DateTime.Today,

								}, 
								new Domain.WeatherForecast
								{
									Id = 2u, 
									Summary = "Sunny", 
									TemperatureC = 32,
									Date = DateTime.Today.AddDays(1),
								}, 
								new Domain.WeatherForecast
								{
									Id = 3u, 
									Summary = "Sunny", 
									TemperatureC = 35,
									Date = DateTime.Today.AddDays(2),
								}
							},
						},
						new Domain.Country()
						{
							Id = 2u,
							Name = "Portugal",
							WeatherForecasts = new List<Domain.WeatherForecast>()
							{
								new Domain.WeatherForecast
								{
									Id = 4u,
									Summary = "Warm",
									TemperatureC = 23,
									Date = DateTime.Today,
								},
								new Domain.WeatherForecast
								{
									Id = 5u,
									Summary = "Warm",
									TemperatureC = 22,
									Date = DateTime.Today.AddDays(1),
								},
								new Domain.WeatherForecast
								{
									Id = 6u,
									Summary = "Mild",
									TemperatureC = 21,
									Date = DateTime.Today.AddDays(2),
								}
							},
						},
					}
				},
				{
					33, new List<Domain.Country>() {}
				},
			};

			var ret = expectedDict[temperature];

			return ret;
		}
	}
}
