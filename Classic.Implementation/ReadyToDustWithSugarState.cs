namespace Classic.Implementation
{
	public class ReadyToDustWithSugarState : ISharlotkaState {
		private readonly IHasState<ISharlotkaState> _sharlotka;
		private readonly ISharlotkaState _successor;

		public ReadyToDustWithSugarState(IHasState<ISharlotkaState> sharlotka, ISharlotkaState successor) {
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
			get { throw new WrongStateException(); }
		}

		public void TurnOut() {
			throw new WrongStateException();
		}

		public void DustWithSugar() {
			_sharlotka.State = _successor;
		}

		public void DustWithCinnamon() {
			throw new WrongStateException();
		}

		public void Serve() {
			throw new WrongStateException();
		}
	}
}