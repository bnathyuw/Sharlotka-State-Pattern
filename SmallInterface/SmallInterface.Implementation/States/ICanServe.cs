namespace SmallInterface.Implementation.States
{
	public interface ICanServe : ISharlotkaState {
		void Serve(IHasState<ISharlotkaState> sharlotka);
	}
}