namespace SmallInterface.Implementation.States
{
	public class ReadyToDustWithSugarState : ICanDustWithSugar {
		private readonly ISharlotkaState _successor;

		public ReadyToDustWithSugarState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void DustWithSugar(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}
}