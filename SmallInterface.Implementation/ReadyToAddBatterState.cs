namespace SmallInterface.Implementation
{
	public class ReadyToAddBatterState : ISharlotkaState, ICanAddBatter {
		private readonly ISharlotkaState _successor;

		public ReadyToAddBatterState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void AddBatter(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}
}