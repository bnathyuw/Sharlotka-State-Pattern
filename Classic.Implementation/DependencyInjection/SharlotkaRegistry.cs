using StructureMap.Configuration.DSL;

namespace Classic.Implementation.DependencyInjection
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<ISharlotka>().Use<Sharlotka>();
		}
	}
}