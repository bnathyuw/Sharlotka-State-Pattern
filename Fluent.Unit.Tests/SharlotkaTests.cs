using Fluent.Implementation;
using Fluent.Implementation.States;
using NUnit.Framework;

namespace Fluent.Unit.Tests
{
	[TestFixture]
	public class SharlotkaTests
	{
		[Test]
		public void Explicit_AddApples_returns_self() {
			var sharlotka = new Sharlotka() as ICanAddApples;

			var canAddBatter = sharlotka.AddApples();

			Assert.That(canAddBatter, Is.EqualTo(sharlotka));
		}
		
		[Test]
		public void Implicity_AddApples_returns_self() {
			var sharlotka = new Sharlotka();

			var canAddBatter = sharlotka.AddApples();

			Assert.That(canAddBatter, Is.EqualTo(sharlotka));
		}

		[Test]
		public void AddBatter_returns_self() {
			var sharlotka = new Sharlotka() as ICanAddBatter;

			var canBake = sharlotka.AddBatter();

			Assert.That(canBake, Is.EqualTo(sharlotka));
		}

		[Test]
		public void Bake_returns_self_after_five_attempts() {
			var sharlotka = new Sharlotka() as ICanBake;

			var canTurnOut = sharlotka.Bake();
			Assert.That(canTurnOut, Is.Null);
			canTurnOut = sharlotka.Bake();
			Assert.That(canTurnOut, Is.Null);
			canTurnOut = sharlotka.Bake();
			Assert.That(canTurnOut, Is.Null);
			canTurnOut = sharlotka.Bake();
			Assert.That(canTurnOut, Is.Null);
			canTurnOut = sharlotka.Bake();
			Assert.That(canTurnOut, Is.EqualTo(sharlotka));
		}

		[Test]
		public void TurnOut_returns_self() {
			var sharlotka = new Sharlotka() as ICanTurnOut;

			var canDustWithSugar = sharlotka.TurnOut();

			Assert.That(canDustWithSugar, Is.EqualTo(sharlotka));
		}

		[Test]
		public void DustWithSugar_returns_self() {
			var sharlotka = new Sharlotka() as ICanDustWithSugar;

			var canDustWithCinnamon = sharlotka.DustWithSugar();

			Assert.That(canDustWithCinnamon, Is.EqualTo(sharlotka));
		}

		[Test]
		public void DustWithCinnamon_returns_self() {
			var sharlotka = new Sharlotka() as ICanDustWithCinnamon;

			var canServe = sharlotka.DustWithCinnamon();

			Assert.That(canServe, Is.EqualTo(sharlotka));
		}
	}
}