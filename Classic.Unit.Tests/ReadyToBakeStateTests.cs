using System;
using Classic.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class ReadyToBakeStateTests
	{
		private ReadyToBakeState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToBakeState(_successor);
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
		public void Can_call_Bake() {
			_state.Bake(_sharlotka);
		}

		[Test]
		public void IsReady_returns_false() {
			var isReady = _state.GetIsReady(_sharlotka);
			Assert.That(isReady, Is.False);
		}

		[Test]
		public void Sets_state_to_successor_after_five_bakes() {
			_state.Bake(_sharlotka);
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			_state.Bake(_sharlotka);
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			_state.Bake(_sharlotka);
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			_state.Bake(_sharlotka);
			_sharlotka.AssertWasNotCalled(s => s.State = _successor);
			_state.Bake(_sharlotka);
			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}

		[Test]
		public void TurnOut_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.TurnOut(_sharlotka));
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