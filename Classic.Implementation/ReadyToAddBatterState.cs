namespace Classic.Implementation
{
	public class ReadyToAddBatterState : ISharlotkaState {
		private readonly IHasState<ISharlotkaState> _sharlotka;
		private readonly ISharlotkaState _successor;

		public ReadyToAddBatterState(IHasState<ISharlotkaState> sharlotka, ISharlotkaState successor) {
			_sharlotka = sharlotka;
			_successor = successor;
		}

		public void AddApples() {
			throw new WrongStateException();
		}

		public void AddBatter() {
			_sharlotka.State = _successor;
		}

		public void Bake() {
			throw new WrongStateException();
		}

		public bool IsReady {
			get { throw new WrongStateException(); }
		}

		public void TurnOut() {
			throw new WrongStateException();
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