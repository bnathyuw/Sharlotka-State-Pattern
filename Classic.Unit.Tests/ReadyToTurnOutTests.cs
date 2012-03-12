using System;
using Classic.Implementation;
using NUnit.Framework;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class ReadyToTurnOutTests
	{
		private ReadyToTurnOutState _state;

		[SetUp]
		public void SetUp() {
			_state = new ReadyToTurnOutState();
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
		public void IsReady_returns_true() {
			var isReady = _state.IsReady;

			Assert.That(isReady, Is.True);
		}

		[Test]
		public void Can_call_TurnOut() {
			_state.TurnOut();
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