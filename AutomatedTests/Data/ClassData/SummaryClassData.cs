using System.Collections;

namespace AutomatedTests.Data.ClassData
{
	public class SummaryClassData : IEnumerable<object[]>
	{
		private readonly List<object[]> summaries = new List<object[]>
		{
			new object[] { "Sunny", },
			new object[] { "Warm", },
			new object[] { "Cool", },
		};

		public IEnumerator<object[]> GetEnumerator() => summaries.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
