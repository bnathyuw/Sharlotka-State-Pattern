﻿using StructureMap;

namespace Fluent.Implementation.DependencyInjection
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
		}
	}
}