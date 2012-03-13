﻿using SmallInterface.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace SmallInterface.Unit.Tests
{
	[TestFixture]
	public class ReadyToAddBatterStateTests
	{
		private ReadyToAddBatterState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToAddBatterState(_successor);
		}

		[Test]
		public void Can_call_AddBatter() {
			_state.AddBatter(_sharlotka);
		}

		[Test]
		public void AddBatter_sets_state_to_successor() {
			_state.AddBatter(_sharlotka);

			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}
	}
}