using Fluent.Implementation.States;

namespace Fluent.Implementation
{
	public class Sharlotka : ICanAddApples, ICanAddBatter, ICanBake, ICanTurnOut, ICanDustWithSugar, ICanDustWithCinnamon, ICanServe
	{
		private int _bakeCount;

		public ICanAddBatter AddApples() {
			return this;
		}

		ICanBake ICanAddBatter.AddBatter() {
			return this;
		}

		ICanTurnOut ICanBake.Bake() {
			_bakeCount++;
			return _bakeCount < 5 ? null : this;
		}

		ICanDustWithSugar ICanTurnOut.TurnOut() {
			return this;
		}

		ICanDustWithCinnamon ICanDustWithSugar.DustWithSugar() {
			return this;
		}

		ICanServe ICanDustWithCinnamon.DustWithCinnamon() {
			return this;
		}

		void ICanServe.Serve() {}
	}
}