namespace SmallInterface.Implementation
{
	public class ReadyToDustWithCinnamonState : ISharlotkaState, ICanDustWithCinnamon {
		private readonly ISharlotkaState _successor;

		public ReadyToDustWithCinnamonState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}
}