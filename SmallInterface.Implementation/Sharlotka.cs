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

	public interface ICanServe : ISharlotkaState {
		void Serve(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanDustWithCinnamon : ISharlotkaState {
		void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanDustWithSugar : ISharlotkaState {
		void DustWithSugar(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanTurnOut : ISharlotkaState {
		void TurnOut(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanGetIsReady : ISharlotkaState {
		bool GetIsReady(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanBake : ISharlotkaState {
		void Bake(IHasState<ISharlotkaState> sharlotka);
	}

	public interface ICanAddBatter : ISharlotkaState {
		void AddBatter(IHasState<ISharlotkaState> sharlotka);
	}
}