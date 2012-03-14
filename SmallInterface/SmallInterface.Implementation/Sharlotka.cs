using SmallInterface.Implementation.States;

namespace SmallInterface.Implementation
{
	internal class Sharlotka : IHasState<ISharlotkaState>, ISharlotka
	{
		private ISharlotkaState _sharlotkaState;

		public Sharlotka(ISharlotkaState sharlotkaState) {
			_sharlotkaState = sharlotkaState;
		}

		public void AddApples() {
			var canAddApples = _sharlotkaState as ICanAddApples;
			if (canAddApples == null) throw new WrongStateException();
			canAddApples.AddApples(this);
		}

		public void AddBatter() {
			var canAddBatter = _sharlotkaState as ICanAddBatter;
			if (canAddBatter == null) throw new WrongStateException();
			canAddBatter.AddBatter(this);
		}

		public void Bake() {
			var canBake = _sharlotkaState as ICanBake;
			if (canBake == null) throw new WrongStateException();
			canBake.Bake(this);
		}

		public bool GetIsReady() {
			var canGetIsReady = _sharlotkaState as ICanGetIsReady;
			if (canGetIsReady == null) throw new WrongStateException();
			return canGetIsReady.GetIsReady(this);
		}

		public void TurnOut() {
			var canTurnOut = _sharlotkaState as ICanTurnOut;
			if (canTurnOut == null) throw new WrongStateException();
			canTurnOut.TurnOut(this);
		}

		public void DustWithSugar() {
			var canDustWithSugar = _sharlotkaState as ICanDustWithSugar;
			if (canDustWithSugar == null) throw new WrongStateException();
			canDustWithSugar.DustWithSugar(this);
		}

		public void DustWithCinnamon() {
			var canDustWithCinnamon = _sharlotkaState as ICanDustWithCinnamon;
			if (canDustWithCinnamon == null) throw new WrongStateException();
			canDustWithCinnamon.DustWithCinnamon(this);
		}

		public void Serve() {
			var canServe = _sharlotkaState as ICanServe;
			if (canServe == null) throw new WrongStateException();
			canServe.Serve(this);
		}

		public ISharlotkaState State {
			set { _sharlotkaState = value; }
		}
	}
}