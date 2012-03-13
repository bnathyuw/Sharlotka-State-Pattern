using StructureMap.Configuration.DSL;

namespace Fluent.Implementation.DependencyInjection
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<Sharlotka>().Use<Sharlotka>();
		}
	}
}