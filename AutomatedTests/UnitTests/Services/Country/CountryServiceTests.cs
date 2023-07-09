using Country;
using FluentAssertions;
using Moq;
using Repositories.Country;

namespace AutomatedTests.UnitTests.Services.Country
{
    public class CountryServiceTests
    {
        [Fact]
        public async Task GetAllAsync_Should_Return_All_Countries()
        {
            var countries = new List<Domain.Country>()
            {
                new Domain.Country()
                {
                    Id = 1,
                    Name = "Country1",
                },
                new Domain.Country()
                {
                    Id = 2,
                    Name = "Country2",
                },
            };

            var countryRepositoryMock = new Mock<ICountryRepository>();
            countryRepositoryMock.Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(countries.AsEnumerable()));
            var countryRepository = countryRepositoryMock.Object;

            var service = new CountryService(countryRepository);
            var result = await service.GetAllAsync();

            result.Should().BeEquivalentTo(countries);
        }
	}
}
