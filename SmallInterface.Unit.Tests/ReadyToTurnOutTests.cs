using SmallInterface.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace SmallInterface.Unit.Tests
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
	}
}