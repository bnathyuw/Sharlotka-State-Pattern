namespace SmallInterface.Implementation
{
	public interface ICanTurnOut : ISharlotkaState {
		void TurnOut(IHasState<ISharlotkaState> sharlotka);
	}
}