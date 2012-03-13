namespace Fluent.Implementation.States
{
	public interface ICanBake : ISharlotkaState {
		void Bake(IHasState<ISharlotkaState> sharlotka);
	}
}