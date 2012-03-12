namespace Classic.Implementation
{
	public class Sharlotka : IHasState<ISharlotkaState>
	{
		private ISharlotkaState _sharlotkaState;

		public Sharlotka(ISharlotkaState sharlotkaState) {
			_sharlotkaState = sharlotkaState;
		}

		public void AddApples() {
			_sharlotkaState.AddApples(this);
		}

		public void AddBatter() {
			_sharlotkaState.AddBatter(this);
		}

		public void Bake() {
			_sharlotkaState.Bake(this);
		}

		public bool GetIsReady() {
			return _sharlotkaState.GetIsReady(this);
		}

		public void TurnOut() {
			_sharlotkaState.TurnOut(this);
		}

		public void DustWithSugar() {
			_sharlotkaState.DustWithSugar(this);
		}

		public void DustWithCinnamon() {
			_sharlotkaState.DustWithCinnamon(this);
		}

		public void Serve() {
			_sharlotkaState.Serve(this);
		}

		public ISharlotkaState State {
			set { _sharlotkaState = value; }
		}
	}
}