using StructureMap;
using StructureMap.Configuration.DSL;

namespace Classic.Implementation
{
	public static class DependencyResolver
	{
		public static IContainer Container {
			get {
				ObjectFactory.Configure(Configure);
				return ObjectFactory.Container;
			}
		}

		private static void Configure(ConfigurationExpression x) {
			x.AddRegistry<SharlotkaRegistry>();
			x.AddRegistry<SharlotkaStateRegistry>();
		}
	}

	public class SharlotkaRegistry:Registry
	{
		public SharlotkaRegistry() {
			For<Sharlotka>().Use<Sharlotka>();
		}
	}

	public class SharlotkaStateRegistry:Registry
	{
		public SharlotkaStateRegistry() {
			For<ISharlotkaState>().Use<ReadyToAddApplesState>().Ctor<ISharlotkaState>().Is(x =>x.GetInstance<ISharlotkaState>("AddBatter"));
			For<ISharlotkaState>().Add<ReadyToAddBatterState>().Named("AddBatter").Ctor<ISharlotkaState>().Is(x => x.GetInstance<ISharlotkaState>("Bake"));
			For<ISharlotkaState>().Add<ReadyToBakeState>().Named("Bake").Ctor<ISharlotkaState>().Is(x => x.GetInstance<ISharlotkaState>("Ready"));
			For<ISharlotkaState>().Add<ReadyToTurnOutState>().Named("Ready").Ctor<ISharlotkaState>().Is(x => x.GetInstance<ISharlotkaState>("DustWithSugar"));
			For<ISharlotkaState>().Add<ReadyToDustWithSugarState>().Named("DustWithSugar").Ctor<ISharlotkaState>().Is(x => x.GetInstance<ISharlotkaState>("DustWithCinnamon"));
			For<ISharlotkaState>().Add<ReadyToDustWithCinnamonState>().Named("DustWithCinnamon").Ctor<ISharlotkaState>().Is(x => x.GetInstance<ISharlotkaState>("Serve"));
			For<ISharlotkaState>().Add<ReadyToServeState>().Named("Serve");
		}
	}
}