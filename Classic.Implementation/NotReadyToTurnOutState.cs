namespace Classic.Implementation
{
	public class NotReadyToTurnOutState : ISharlotkaState {
		private readonly IHasState<ISharlotkaState> _sharlotka;
		private readonly ISharlotkaState _successor;
		private int _callCount;

		public NotReadyToTurnOutState(IHasState<ISharlotkaState> sharlotka, ISharlotkaState successor) {
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
			get {
				_callCount++;
				if (_callCount == 5) {
					_sharlotka.State = _successor;
				}
				return false;
			}
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