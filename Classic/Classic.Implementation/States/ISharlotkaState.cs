namespace Classic.Implementation.States
{
	public interface ISharlotkaState {
		void AddApples(IHasState<ISharlotkaState> sharlotka);
		void AddBatter(IHasState<ISharlotkaState> sharlotka);
		void Bake(IHasState<ISharlotkaState> sharlotka);
		bool GetIsReady(IHasState<ISharlotkaState> sharlotka);
		void TurnOut(IHasState<ISharlotkaState> sharlotka);
		void DustWithSugar(IHasState<ISharlotkaState> sharlotka);
		void DustWithCinnamon(IHasState<ISharlotkaState> sharlotka);
		void Serve(IHasState<ISharlotkaState> sharlotka);
	}
}