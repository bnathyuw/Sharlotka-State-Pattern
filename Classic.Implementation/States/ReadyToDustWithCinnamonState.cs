namespace Classic.Implementation.States
{
	public class ReadyToDustWithCinnamonState : ISharlotkaState {
		private readonly ISharlotkaState _successor;

		public ReadyToDustWithCinnamonState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void AddApples(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void AddBatter(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void Bake(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public bool GetIsReady(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void TurnOut(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void DustWithSugar(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}

		public void Serve(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}
	}
}