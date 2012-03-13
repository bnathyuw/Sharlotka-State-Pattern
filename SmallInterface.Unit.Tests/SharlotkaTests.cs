using SmallInterface.Implementation;
using NUnit.Framework;
using Rhino.Mocks;
using SmallInterface.Implementation.States;

namespace SmallInterface.Unit.Tests
{
	[TestFixture]
	public class SharlotkaTests
	{
		[Test]
		public void AddApples_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanAddApples>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.AddApples();

			sharlotkaState.AssertWasCalled(ss => ss.AddApples(sharlotka));
		}

		[Test]
		public void AddBatter_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanAddBatter>();
			var sharlotka = new Sharlotka(sharlotkaState);
	
			sharlotka.AddBatter();

			sharlotkaState.AssertWasCalled(ss => ss.AddBatter(sharlotka));
		}

		[Test]
		public void Bake_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanBake>();
			var sharlotka = new Sharlotka(sharlotkaState);
			
			sharlotka.Bake();

			sharlotkaState.AssertWasCalled(ss => ss.Bake(sharlotka));
		}

		[Test]
		public void IsReady_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanGetIsReady>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.GetIsReady();

			sharlotkaState.AssertWasCalled(ss => ss.GetIsReady(sharlotka));
		}

		[Test]
		public void TurnOut_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanTurnOut>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.TurnOut();

			sharlotkaState.AssertWasCalled(ss => ss.TurnOut(sharlotka));
		}

		[Test]
		public void DustWithSugar_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanDustWithSugar>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.DustWithSugar();

			sharlotkaState.AssertWasCalled(ss => ss.DustWithSugar(sharlotka));
		}

		[Test]
		public void DustWithCinnamon_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanDustWithCinnamon>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.DustWithCinnamon();

			sharlotkaState.AssertWasCalled(ss => ss.DustWithCinnamon(sharlotka));
		}

		[Test]
		public void Serve_calls_state() {
			var sharlotkaState = MockRepository.GenerateStub<ICanServe>();
			var sharlotka = new Sharlotka(sharlotkaState);

			sharlotka.Serve();

			sharlotkaState.AssertWasCalled(ss => ss.Serve(sharlotka));
		}	 
	}
}