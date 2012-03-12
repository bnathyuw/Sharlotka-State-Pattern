using StructureMap.Configuration.DSL;

namespace SmallInterface.Implementation
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<Sharlotka>().Use<Sharlotka>();
		}
	}
}