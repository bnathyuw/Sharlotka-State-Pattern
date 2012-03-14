using NUnit.Framework;
using Rhino.Mocks;
using SmallInterface.Implementation.States;

namespace SmallInterface.Unit.Tests.States
{
	[TestFixture]
	public class ReadyToAddApplesStateTests
	{
		private ReadyToAddApplesState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToAddApplesState(_successor);
		}

		[Test]
		public void Can_call_AddApples() {
			_state.AddApples(_sharlotka);
		}

		[Test]
		public void AddApples_sets_state_to_successor() {
			_state.AddApples(_sharlotka);
			
			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}
	}
}