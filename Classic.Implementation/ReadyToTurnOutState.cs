namespace Classic.Implementation
{
	public class ReadyToTurnOutState : ISharlotkaState {
		private readonly ISharlotkaState _successor;

		public ReadyToTurnOutState(ISharlotkaState successor) {
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
			return true;
		}

		public void TurnOut(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}

		public void DustWithSugar(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void Serve(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}
	}
}