using System;
using Classic.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class NotReadyToTurnOutTests
	{
		private NotReadyToTurnOutState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new NotReadyToTurnOutState(_sharlotka, _successor);
		}

		[Test]
		public void AddApples_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.AddApples());
		}

		[Test]
		public void AddBatter_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.AddBatter());
		}

		[Test]
		public void Bake_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.Bake());
		}

		[Test]
		public void IsReady_returns_false() {
			var isReady = _state.IsReady;
			Assert.That(isReady, Is.False);
		}

		[Test]
		public void IsReady_sets_state_to_successor_after_fifth_call() {
			var isReady = _state.IsReady;
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			isReady = _state.IsReady;
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			isReady = _state.IsReady;
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			isReady = _state.IsReady;
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			isReady = _state.IsReady;
			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}

		[Test]
		public void TurnOut_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.TurnOut());
		}

		[Test]
		public void DustWithSugar_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.DustWithSugar());
		}

		[Test]
		public void DustWithCinnamon_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.DustWithCinnamon());
		}

		[Test]
		public void Serve_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.Serve());
		}
	}
}