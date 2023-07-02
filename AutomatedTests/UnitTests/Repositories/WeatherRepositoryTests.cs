using AutomatedTests.Data.ClassData;
using FluentAssertions;
using Repositories;

namespace AutomatedTests.UnitTests.Repositories
{
	public class WeatherRepositoryTests
	{
		[Theory]
		[ClassData(typeof(SummaryClassData))]
		public async Task GetAllForecastsBySummaryAsync_Should_Return_Forecasts_With_Passed_Summary(string summary)
		{
			var repository = new WeatherRepository();
			var result = await repository.GetAllForecastsBySummaryAsync(summary);

			foreach(var item in result)
			{
				item.Summary.Should().Be(summary);
			}
		}
	}
}
