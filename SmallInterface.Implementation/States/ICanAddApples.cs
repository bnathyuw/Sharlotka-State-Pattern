namespace SmallInterface.Implementation.States
{
	public interface ICanAddApples : ISharlotkaState
	{
		void AddApples(IHasState<ISharlotkaState> sharlotka);
	}
}