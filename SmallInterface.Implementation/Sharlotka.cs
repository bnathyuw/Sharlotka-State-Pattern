using SmallInterface.Implementation.States;

namespace SmallInterface.Implementation
{
	public class Sharlotka : IHasState<ISharlotkaState>
	{
		private ISharlotkaState _sharlotkaState;

		public Sharlotka(ISharlotkaState sharlotkaState) {
			_sharlotkaState = sharlotkaState;
		}

		public void AddApples() {
			var canAddApples = _sharlotkaState as ICanAddApples;
			if (canAddApples != null) canAddApples.AddApples(this);
		}

		public void AddBatter() {
			var canAddBatter = _sharlotkaState as ICanAddBatter;
			if (canAddBatter != null) canAddBatter.AddBatter(this);
		}

		public void Bake() {
			var canBake = _sharlotkaState as ICanBake;
			if (canBake != null) canBake.Bake(this);
		}

		public bool GetIsReady() {
			var canGetIsReady = _sharlotkaState as ICanGetIsReady;
			return canGetIsReady != null && canGetIsReady.GetIsReady(this);
		}

		public void TurnOut() {
			var canTurnOut = _sharlotkaState as ICanTurnOut;
			if(canTurnOut != null) canTurnOut.TurnOut(this);
		}

		public void DustWithSugar() {
			var canDustWithSugar = _sharlotkaState as ICanDustWithSugar;
			if(canDustWithSugar != null) canDustWithSugar.DustWithSugar(this);
		}

		public void DustWithCinnamon() {
			var canDustWithCinnamon = _sharlotkaState as ICanDustWithCinnamon;
			if(canDustWithCinnamon != null) canDustWithCinnamon.DustWithCinnamon(this);
		}

		public void Serve() {
			var canServe = _sharlotkaState as ICanServe;
			if(canServe != null) canServe.Serve(this);
		}

		public ISharlotkaState State {
			set { _sharlotkaState = value; }
		}
	}
}