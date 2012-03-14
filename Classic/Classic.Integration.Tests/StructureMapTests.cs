using Classic.Implementation.DependencyInjection;
using NUnit.Framework;

namespace Classic.Integration.Tests
{
	[TestFixture]
	public class StructureMapTests
	{
		[Test]
		public void Configuration_is_valid() {
			var container = DependencyResolver.Container;
			container.AssertConfigurationIsValid();
		}
	}
}