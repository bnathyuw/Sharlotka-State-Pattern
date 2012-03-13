namespace Fluent.Implementation.States
{
	public interface ICanDustWithCinnamon : ISharlotkaState {
		void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka);
	}
}