using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;


namespace AutomatedTests.Fixtures
{
	public class ApplicationFixture : WebApplicationFactory<Program>
	{
		public HttpClient CreateTestClient()
		{
			var client = this.CreateClient();

			return client;
		}

		protected override void ConfigureWebHost(IWebHostBuilder builder)
		{
			base.ConfigureWebHost(builder);
		}
	}
}
