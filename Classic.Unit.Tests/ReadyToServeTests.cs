using System;
using Classic.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class ReadyToServeTests
	{
		private ReadyToServeState _state;
		private IHasState<ISharlotkaState> _sharlotka;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_state = new ReadyToServeState(_sharlotka);
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
		public void Can_call_Serve() {
			_state.Serve();
		}
	}
}