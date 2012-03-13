namespace SmallInterface.Implementation.States
{
	public class ReadyToBakeState : ICanBake, ICanGetIsReady {
		private readonly ISharlotkaState _successor;
		private int _bakeCount;
		public ReadyToBakeState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void Bake(IHasState<ISharlotkaState> sharlotka) {
			_bakeCount++;
			if (_bakeCount >= 5) {
				sharlotka.State = _successor;
			}
		}

		public bool GetIsReady(IHasState<ISharlotkaState> sharlotka) {
			return false;
		}
	}
}