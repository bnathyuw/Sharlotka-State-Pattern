namespace SmallInterface.Implementation.States
{
	public interface ICanAddBatter : ISharlotkaState {
		void AddBatter(IHasState<ISharlotkaState> sharlotka);
	}
}