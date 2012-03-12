namespace Classic.Implementation
{
	public interface ISharlotkaState {
		void AddApples();
		void AddBatter();
		void Bake();
		bool IsReady { get; }
		void TurnOut();
		void DustWithSugar();
		void DustWithCinnamon();
		void Serve();
	}
}