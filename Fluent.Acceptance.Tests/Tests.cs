using Fluent.Implementation;
using Fluent.Implementation.DependencyInjection;
using Fluent.Implementation.States;
using NUnit.Framework;

namespace Fluent.Acceptance.Tests
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Happy_path() {
			var container = DependencyResolver.Container;
			var sharlotka = container.GetInstance<Sharlotka>();
			var canBake = sharlotka
				.AddApples()
				.AddBatter();
			
			ICanTurnOut canTurnOut;
			do {
				canTurnOut = canBake.Bake();
			} while (canTurnOut == null);

			canTurnOut
				.TurnOut()
				.DustWithSugar()
				.DustWithCinnamon()
				.Serve();
		}
	}
}