namespace Classic.Implementation
{
	public class Sharlotka
	{
		private readonly ISharlotkaState _sharlotkaState;

		public Sharlotka(ISharlotkaState sharlotkaState) {
			_sharlotkaState = sharlotkaState;
		}

		public void AddApples() {
			_sharlotkaState.AddApples();
		}

		public void AddBatter() {
			_sharlotkaState.AddBatter();
		}

		public void Bake() {
			_sharlotkaState.Bake();
		}

		public bool IsReady {
			get { return _sharlotkaState.IsReady; }
		}

		public void TurnOut() {
			_sharlotkaState.TurnOut();
		}

		public void DustWithSugar() {
			_sharlotkaState.DustWithSugar();
		}

		public void DustWithCinnamon() {
			_sharlotkaState.DustWithCinnamon();
		}

		public void Serve() {
			_sharlotkaState.Serve();
		}
	}
}