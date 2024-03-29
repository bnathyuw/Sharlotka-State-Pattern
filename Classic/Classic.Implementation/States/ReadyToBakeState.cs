namespace Classic.Implementation.States
{
	public class ReadyToBakeState : ISharlotkaState {
		private readonly ISharlotkaState _successor;
		private int _bakeCount;
		public ReadyToBakeState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void AddApples(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void AddBatter(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
		}

		public void Bake(IHasState<ISharlotkaState> sharlotka) {
			_bakeCount++;
			if (_bakeCount >= 5) {
				sharlotka.State = _successor;
			}
		}

		public bool GetIsReady(IHasState<ISharlotkaState> sharlotka) {
			return false;
		}

		public void TurnOut(IHasState<ISharlotkaState> sharlotka) {
			throw new WrongStateException();
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