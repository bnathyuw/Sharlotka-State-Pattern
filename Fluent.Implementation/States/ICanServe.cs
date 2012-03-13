namespace Fluent.Implementation.States
{
	public interface ICanServe : ISharlotkaState {
		void Serve(IHasState<ISharlotkaState> sharlotka);
	}
}