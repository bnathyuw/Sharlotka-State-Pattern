using SmallInterface.Implementation;
using NUnit.Framework;
using Rhino.Mocks;

namespace SmallInterface.Unit.Tests
{
	[TestFixture]
	public class ReadyToDustWithSugarTests
	{
		private ReadyToDustWithSugarState _state;
		private IHasState<ISharlotkaState> _sharlotka;
		private ISharlotkaState _successor;

		[SetUp]
		public void SetUp() {
			_sharlotka = MockRepository.GenerateStub<IHasState<ISharlotkaState>>();
			_successor = MockRepository.GenerateStub<ISharlotkaState>();
			_state = new ReadyToDustWithSugarState(_successor);
		}

		[Test]
		public void Can_call_DustWithSugar() {
			_state.DustWithSugar(_sharlotka);
		}

		[Test]
		public void DustWithSugar_sets_state_to_successor() {
			_state.DustWithSugar(_sharlotka);

			_sharlotka.AssertWasCalled(s => s.State = _successor);
		}
	}
}