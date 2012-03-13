namespace SmallInterface.Implementation
{
	public interface ICanAddBatter : ISharlotkaState {
		void AddBatter(IHasState<ISharlotkaState> sharlotka);
	}
}