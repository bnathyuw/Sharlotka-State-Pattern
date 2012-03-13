﻿using NUnit.Framework;
using SmallInterface.Implementation;

namespace SmallInterface.AcceptanceTests
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Happy_path() {
			var container = DependencyResolver.Container;
			var sharlotka = container.GetInstance<Sharlotka>();
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