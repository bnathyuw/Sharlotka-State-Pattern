﻿using NUnit.Framework;
using Rhino.Mocks;
using SmallInterface.Implementation.States;

namespace SmallInterface.Unit.Tests.States
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
		public void Can_call_DustWithCinnamon() {
			_state.DustWithCinnamon(_sharlotka);
		}

		[Test]
		public void DustWithCinnamon_sets_state_to_successor() {
			_state.DustWithCinnamon(_sharlotka);

			_sharlotka.AssertWasCalled(s => s.State = _successor);

		}
	}
}