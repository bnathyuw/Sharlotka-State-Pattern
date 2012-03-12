namespace SmallInterface.Implementation
{
	public class ReadyToAddApplesState : ISharlotkaState, ICanAddApples {
		private readonly ISharlotkaState _successor;

		public ReadyToAddApplesState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void AddApples(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}

	public interface ICanAddApples
	{
		void AddApples(IHasState<ISharlotkaState> sharlotka);
	}
}