namespace Fluent.Implementation.States
{
	public class ReadyToAddApplesState : ICanAddApples {
		private readonly ISharlotkaState _successor;

		public ReadyToAddApplesState(ISharlotkaState successor) {
			_successor = successor;
		}

		public void AddApples(IHasState<ISharlotkaState> sharlotka) {
			sharlotka.State = _successor;
		}
	}
}