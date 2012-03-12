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
			_state = new ReadyToBakeState(_sharlotka, _successor);
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
		public void Can_call_Bake() {
			_state.Bake();
		}

		[Test]
		public void Bake_sets_state_to_successor() {
			_state.Bake();

			_sharlotka.AssertWasCalled(s => s.State = _successor);
		
		}

		[Test]
		public void IsReady_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => { var isReady = _state.IsReady; });
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