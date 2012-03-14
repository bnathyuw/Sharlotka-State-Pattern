using Classic.Implementation;
using Classic.Implementation.States;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class SharlotkaTests
	{
		private Sharlotka _sharlotka;
		private ISharlotkaState _sharlotkaState;

		[SetUp]
		public void SetUp() {
			_sharlotkaState = MockRepository.GenerateStub<ISharlotkaState>();
			_sharlotka = new Sharlotka(_sharlotkaState);
		}

		[Test]
		public void AddApples_calls_state() {
			_sharlotka.AddApples();

			_sharlotkaState.AssertWasCalled(ss => ss.AddApples(_sharlotka));
		}

		[Test]
		public void AddBatter_calls_state() {
			_sharlotka.AddBatter();

			_sharlotkaState.AssertWasCalled(ss => ss.AddBatter(_sharlotka));
		}

		[Test]
		public void Bake_calls_state() {
			_sharlotka.Bake();

			_sharlotkaState.AssertWasCalled(ss => ss.Bake(_sharlotka));
		}

		[Test]
		public void IsReady_calls_state() {
			_sharlotka.GetIsReady();

			_sharlotkaState.AssertWasCalled(ss => ss.GetIsReady(_sharlotka));
		}

		[Test]
		public void TurnOut_calls_state() {
			_sharlotka.TurnOut();

			_sharlotkaState.AssertWasCalled(ss => ss.TurnOut(_sharlotka));
		}

		[Test]
		public void DustWithSugar_calls_state() {
			_sharlotka.DustWithSugar();

			_sharlotkaState.AssertWasCalled(ss => ss.DustWithSugar(_sharlotka));
		}

		[Test]
		public void DustWithCinnamon_calls_state() {
			_sharlotka.DustWithCinnamon();

			_sharlotkaState.AssertWasCalled(ss => ss.DustWithCinnamon(_sharlotka));
		}

		[Test]
		public void Serve_calls_state() {
			_sharlotka.Serve();

			_sharlotkaState.AssertWasCalled(ss => ss.Serve(_sharlotka));
		}	 
	}
}