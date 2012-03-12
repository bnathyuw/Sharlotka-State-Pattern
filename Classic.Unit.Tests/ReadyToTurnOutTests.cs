using Classic.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class ReadyToTurnOutTests
	{
		private ReadyToTurnOutState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToTurnOutState(_successor);
		}

		[Test]
		public void AddApples_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.AddApples(_sharlotka));
		}

		[Test]
		public void AddBatter_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.AddBatter(_sharlotka));
		}

		[Test]
		public void Bake_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.Bake(_sharlotka));
		}

		[Test]
		public void IsReady_returns_true() {
			var isReady = _state.GetIsReady(_sharlotka);

			Assert.That(isReady, Is.True);
		}

		[Test]
		public void Can_call_TurnOut() {
			_state.TurnOut(_sharlotka);
		}

		[Test]
		public void TurnOut_sets_state_to_successor() {
			_state.TurnOut(_sharlotka);

			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}

		[Test]
		public void DustWithSugar_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.DustWithSugar(_sharlotka));
		}

		[Test]
		public void DustWithCinnamon_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.DustWithCinnamon(_sharlotka));
		}

		[Test]
		public void Serve_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.Serve(_sharlotka));
		}
	}
}