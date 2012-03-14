using Fluent.Implementation.States;
using StructureMap.Configuration.DSL;

namespace Fluent.Implementation.DependencyInjection
{
	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<ISharlotka>().Use<Sharlotka>();
		}
	}
}