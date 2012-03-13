namespace Fluent.Implementation.States
{
	public interface ICanAddBatter : ISharlotkaState {
		void AddBatter(IHasState<ISharlotkaState> sharlotka);
	}
}