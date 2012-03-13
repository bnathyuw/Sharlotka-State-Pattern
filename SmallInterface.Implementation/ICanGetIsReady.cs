namespace SmallInterface.Implementation
{
	public interface ICanGetIsReady : ISharlotkaState {
		bool GetIsReady(IHasState<ISharlotkaState> sharlotka);
	}
}