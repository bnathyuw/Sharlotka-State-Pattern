using Fluent.Implementation.DependencyInjection;
using NUnit.Framework;

namespace Fluent.Integration.Tests
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