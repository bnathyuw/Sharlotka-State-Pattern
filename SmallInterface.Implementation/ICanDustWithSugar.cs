namespace SmallInterface.Implementation
{
	public interface ICanDustWithSugar : ISharlotkaState {
		void DustWithSugar(IHasState<ISharlotkaState> sharlotka);
	}
}