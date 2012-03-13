namespace SmallInterface.Implementation
{
	public interface ICanServe : ISharlotkaState {
		void Serve(IHasState<ISharlotkaState> sharlotka);
	}
}