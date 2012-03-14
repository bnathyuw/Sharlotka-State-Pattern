namespace SmallInterface.Implementation.States
{
	public interface ICanGetIsReady : ISharlotkaState {
		bool GetIsReady(IHasState<ISharlotkaState> sharlotka);
	}
}