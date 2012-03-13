﻿using Fluent.Implementation.States;
using NUnit.Framework;
using Rhino.Mocks;

namespace Fluent.Unit.Tests.States
{
	[TestFixture]
	public class ReadyToServeTests
	{
		private ReadyToServeState _state;
		private IHasState<ISharlotkaState> _sharlotka;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_state = new ReadyToServeState();
		}

		[Test]
		public void Can_call_Serve() {
			_state.Serve(_sharlotka);
		}
	}
}