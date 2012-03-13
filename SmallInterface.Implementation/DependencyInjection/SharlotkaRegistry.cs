using StructureMap.Configuration.DSL;

namespace SmallInterface.Implementation.DependencyInjection
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<Sharlotka>().Use<Sharlotka>();
		}
	}
}