﻿using Classic.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace Classic.Unit.Tests
{
	[TestFixture]
	public class ReadyToDustWithCinnamonTests
	{
		private ReadyToDustWithCinnamonState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToDustWithCinnamonState(_successor);
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
		public void IsReady_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.GetIsReady(_sharlotka));
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
		public void Can_call_DustWithCinnamon() {
			_state.DustWithCinnamon(_sharlotka);
		}

		[Test]
		public void DustWithCinnamon_sets_state_to_successor() {
			_state.DustWithCinnamon(_sharlotka);

			_sharlotka.AssertWasCalled(s => s.State = _successor);

		}

		[Test]
		public void Serve_throws_WrongStateException() {
			Assert.Throws<WrongStateException>(() => _state.Serve(_sharlotka));
		}
	}
}