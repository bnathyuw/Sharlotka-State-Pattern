namespace SmallInterface.Implementation
{
	public interface ICanAddApples : ISharlotkaState
	{
		void AddApples(IHasState<ISharlotkaState> sharlotka);
	}
}