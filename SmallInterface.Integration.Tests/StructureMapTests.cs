using SmallInterface.Implementation;
using NUnit.Framework;

namespace SmallInterface.Integration.Tests
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