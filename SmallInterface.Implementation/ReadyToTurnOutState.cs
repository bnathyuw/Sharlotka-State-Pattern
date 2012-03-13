namespace SmallInterface.Implementation
{
	public class ReadyToTurnOutState : ICanTurnOut, ICanGetIsReady {
		private readonly ISharlotkaState _successor;

		public ReadyToTurnOutState(ISharlotkaState successor) {
			_successor = successor;
		}

		public bool GetIsReady(IHasState<ISharlotkaState> sharlotka) {
			return true;
		}

		public void TurnOut(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}
}