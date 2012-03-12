namespace Classic.Implementation
{
	public class ReadyToDustWithCinnamonState : ISharlotkaState {
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