namespace SmallInterface.Implementation.States
{
	public interface ICanDustWithSugar : ISharlotkaState {
		void DustWithSugar(IHasState<ISharlotkaState> sharlotka);
	}
}