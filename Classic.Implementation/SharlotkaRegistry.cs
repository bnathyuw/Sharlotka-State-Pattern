using StructureMap.Configuration.DSL;

namespace Classic.Implementation
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<Sharlotka>().Use<Sharlotka>();
		}
	}
}