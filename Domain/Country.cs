namespace Domain
{
	public class Country : AbstractModel
	{
		public string Name { get; set; }
		public WeatherForecast WeatherForecastToday => this.WeatherForecasts?.FirstOrDefault(w => DateTime.Today.Equals(w.Date.Date));
		public IEnumerable<WeatherForecast> WeatherForecasts { get; set;}
	}
}
