﻿using Classic.Implementation;
using Classic.Implementation.DependencyInjection;
using NUnit.Framework;

namespace Classic.Acceptance.Tests
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Happy_path() {
			var container = DependencyResolver.Container;
			var sharlotka = container.GetInstance<ISharlotka>();
			sharlotka.AddApples();
			sharlotka.AddBatter();
			do {
				sharlotka.Bake();
			} while (!sharlotka.GetIsReady()); 
			sharlotka.TurnOut();
			sharlotka.DustWithSugar();
			sharlotka.DustWithCinnamon();
			sharlotka.Serve();
		}
	}
}