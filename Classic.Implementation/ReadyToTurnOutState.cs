namespace Classic.Implementation
{
	public class ReadyToTurnOutState : ISharlotkaState {
		private readonly IHasState<ISharlotkaState> _sharlotka;
		private readonly ISharlotkaState _successor;

		public ReadyToTurnOutState(IHasState<ISharlotkaState> sharlotka, ISharlotkaState successor) {
			_sharlotka = sharlotka;
			_successor = successor;
		}

		public void AddApples() {
			throw new WrongStateException();
		}

		public void AddBatter() {
			throw new WrongStateException();
		}

		public void Bake() {
			throw new WrongStateException();
		}

		public bool IsReady {
			get { return true; }
		}

		public void TurnOut() {
			_sharlotka.State = _successor;
		}

		public void DustWithSugar() {
			throw new WrongStateException();
		}

		public void DustWithCinnamon() {
			throw new WrongStateException();
		}

		public void Serve() {
			throw new WrongStateException();
		}
	}
}