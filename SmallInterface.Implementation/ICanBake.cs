namespace SmallInterface.Implementation
{
	public interface ICanBake : ISharlotkaState {
		void Bake(IHasState<ISharlotkaState> sharlotka);
	}
}