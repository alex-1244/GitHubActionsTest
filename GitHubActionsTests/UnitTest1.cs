using System;
using Xunit;

namespace GitHubActionsTests
{
	public class ServiceTests
	{
		[Fact]
		public void Passing()
		{
			Assert.Equal(2, 2);
		}

		[Fact]
		public void Failing()
		{
			Assert.Equal(2, 3);
		}
	}
}
