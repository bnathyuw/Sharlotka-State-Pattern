namespace SmallInterface.Implementation.States
{
	public interface ICanTurnOut : ISharlotkaState {
		void TurnOut(IHasState<ISharlotkaState> sharlotka);
	}
}