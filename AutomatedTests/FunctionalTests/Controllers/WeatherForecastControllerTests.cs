using AutomatedTests.Fixtures;
using Domain;
using FluentAssertions;
using Newtonsoft.Json;

namespace AutomatedTests.FunctionalTests.Controllers
{
	public class WeatherForecastControllerTests : IClassFixture<ApplicationFixture>
	{
		private readonly HttpClient client;

		public WeatherForecastControllerTests(ApplicationFixture applicationFixture)
		{
			this.client = applicationFixture.CreateClient();
		}

		[Fact]
		public async Task GetAllForecastsForTomorrow_Should_Return_All_Weather_For_Tomorrow()
		{
			var result = await client.GetAsync("WeatherForecast/GetAllForecastsForTomorrow/");

			var resultString = await result.Content.ReadAsStringAsync();

			Assert.True(result.IsSuccessStatusCode);

			var weatherForecasts = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(resultString);

			foreach (var forecast in weatherForecasts)
			{
				forecast.Date.Should().Be(DateTime.Today.AddDays(1));
			}
		}

	}
}
