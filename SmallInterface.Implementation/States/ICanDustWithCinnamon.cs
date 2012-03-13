namespace SmallInterface.Implementation.States
{
	public interface ICanDustWithCinnamon : ISharlotkaState {
		void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka);
	}
}